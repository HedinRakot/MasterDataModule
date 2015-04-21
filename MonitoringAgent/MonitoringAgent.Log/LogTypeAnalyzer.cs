using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Log
{
    /// <summary>
    /// Class for analyze log
    /// </summary>
    public class LogTypeAnalyzer
    {
        private readonly LogTypeInfo logTypeInfo;
        private readonly IManagersProvider managersProvider;
        private readonly Regex messagePattern;
        private readonly Regex startMessagePattern;

        /// <summary>
        /// Ctor
        /// </summary>
        public LogTypeAnalyzer(LogTypeInfo logTypeInfo, IManagersProvider managersProvider)
        {
            this.logTypeInfo = logTypeInfo;
            this.managersProvider = managersProvider;
            messagePattern = new Regex(logTypeInfo.MessagePattern, RegexOptions.IgnorePatternWhitespace);
            startMessagePattern = new Regex(logTypeInfo.StartMessagePattern);
        }
        /// <summary>
        /// Analyze logs
        /// </summary>
        public void Analyze()
        {
            StartAnalyze();
        }

        private void StartAnalyze()
        {
            if (Directory.Exists(logTypeInfo.FilePath))
            {
                var files = Directory.GetFiles(logTypeInfo.FilePath, logTypeInfo.FilePattern).Select(f => new FileInfo(f)).ToList();

                files.Sort(new FileInfoComparer());

                for (var i = 0; i < files.Count; i++)
                {
                    var file = files[i];

                    if (logTypeInfo.LastReadDate.HasValue && file.LastWriteTime <= logTypeInfo.LastReadDate)
                        continue;

                    using (var stream = File.OpenRead(file.FullName))
                    {
                        if (logTypeInfo.LastReadPosition.HasValue && String.Compare(file.Name, logTypeInfo.LastProcessedFile, StringComparison.Ordinal) == 0)
                        {
                            stream.Seek(logTypeInfo.LastReadPosition.Value, SeekOrigin.Begin);
                        }
                        logTypeInfo.LastReadPosition = null;


                        var reader = new StreamReader(stream);
                        var newEntities = ProcessFile(reader);

                        SaveNewEntities(newEntities);

                        if (i == files.Count - 1)
                        {
                            logTypeInfo.LastReadPosition = stream.Position;
                            logTypeInfo.LastProcessedFile = file.Name;
                        }
                    }
                }

                logTypeInfo.LastReadDate = DateTime.Now;
                var logTypeManager = managersProvider.GetManager<ILogTypeInfoManager>();
                logTypeManager.AddOrUpdateEntities(new[] {logTypeInfo});
                logTypeManager.SaveChanges();
            }
        }
        private void SaveNewEntities(List<ApplicationLogs> newEntries)
        {
            var appLogsManager = managersProvider.GetManager<IApplicationLogsManager>();
            appLogsManager.AddOrUpdateEntities(newEntries.ToArray());
            appLogsManager.SaveChanges();
        }
        private List<ApplicationLogs> ProcessFile(StreamReader reader)
        {
            var newEntries = new List<ApplicationLogs>();
            var message = new StringBuilder();
            var messageStarted = false;
            do
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    if (startMessagePattern.IsMatch(line))
                    {
                        if (messageStarted)
                        {
                            var newEntry = ProcessMessage(message);
                            if (newEntry != null)
                            {
                                newEntries.Add(newEntry);
                            }
                            message = new StringBuilder();
                        }
                        else
                        {
                            messageStarted = true;
                        }
                    }
                    message.Append(line);
                }
            } while (!reader.EndOfStream);

            if (message.Length > 0) // Last message
            {
                var newEntry = ProcessMessage(message);
                if (newEntry != null)
                {
                    newEntries.Add(newEntry);
                }
            }
            return newEntries;
        }
        private ApplicationLogs ProcessMessage(StringBuilder message)
        {
            var match = messagePattern.Match(message.ToString());
            
            var messageType = string.Empty;
            var text = string.Empty;
            var date = string.Empty;

            if (match.Success)
            {
                if (match.Groups.Count > 0)
                {
                    if (match.Groups["messageType"].Success)
                    {
                        messageType = match.Groups["messageType"].Value;
                    }
                    if (match.Groups["time"].Success)
                    {
                        date = match.Groups["time"].Value;
                    }
                    if (match.Groups["message"].Success)
                    {
                        text = match.Groups["message"].Value;
                    }

                    if (!string.IsNullOrWhiteSpace(messageType) && !string.IsNullOrWhiteSpace(date) && !string.IsNullOrWhiteSpace(text))
                    {
                        var appLogEntity = new ApplicationLogs {LogTypeInfoId = logTypeInfo.Id, LogLevel = GetMessageType(messageType)};
                        //TODO Decide problem with date locale
                        if (date.LastIndexOf('|') != -1)
                        {
                            date = date.Substring(0, date.LastIndexOf('|'));
                        }
                        if (date.LastIndexOf(',') != -1)
                        {
                            date = date.Replace(',', '.');
                        }
                        DateTime result;
                        if (DateTime.TryParse(date, out result))
                        {
                            appLogEntity.Date = result;
                        }

                        appLogEntity.Message = text;
                        return appLogEntity;
                    }
                }
            }
            return null;
        }
        private int GetMessageType(string messageType)
        {
            switch (messageType.ToUpper())
            {
                case "INFO":
                    return 1;
                case "DEBUG":
                    return 2;
                case "ERROR":
                    return 3;
                case "METRICS":
                    return 4;
                default:
                    return 0;
            }
        }

        #region Nested types
        private class FileInfoComparer: IComparer<FileInfo>
        {
            public int Compare(FileInfo x, FileInfo y)
            {
                return x.LastWriteTime.CompareTo(y.LastWriteTime);
            }
        }
        #endregion Nested types
    }
}