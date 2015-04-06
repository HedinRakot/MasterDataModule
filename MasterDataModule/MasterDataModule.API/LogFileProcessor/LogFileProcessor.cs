using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Enums;

namespace MasterDataModule.API.LogFileProcessor
{
    /// <summary>
    /// Implementation of file processor fo logs files
    /// </summary>
    public class LogFileProcessor : AbstractFileProcessor
    {
        const string Pattern =
            @"^=== (?<type>.*)\t(?<year>\d{4})-(?<month>\d{2})-(?<day>\d{2})\s" +
            @"(?<hour>\d{2}):(?<minute>\d{2}):(?<second>\d{2})" +
            @"(?<useless1>.{4,12})(?<text>.+)";

       protected override List<ApplicationLogs> ProcessData(IReadOnlyCollection<string> content)
        {
            var entities = new List<ApplicationLogs>();
           foreach (var line in content)
            {
                //try to macth the line using regular expressions
                var parsed = Regex.Match(line, Pattern);
                if (parsed.Success)
                {
                    entities.Add(CreateEntity(parsed));
                }
            }
            return entities.Where(e => e != null).ToList();
        }

        private ApplicationLogs CreateEntity(Match parsed)
        {
            var entity = new ApplicationLogs();
            var logLevel = GetLogLevel(parsed.Groups["type"].Value);
            if (logLevel == LogLevelEnum.None)
            {
                return null;
            }
            entity.LogLevel = (int)logLevel;
            entity.LogType = (int)LogTypeEnum.FeServiceMain;
            entity.Date = CreateDate(parsed);
            entity.Message = parsed.Groups["text"].Value;
            return entity;
        }

        private LogLevelEnum GetLogLevel(String logLevel)
        {
            LogLevelEnum e;
            if (!Enum.TryParse(logLevel, true, out e))
            {
                e = LogLevelEnum.None;
            }
            return e;
        }

        private static DateTime? CreateDate(Match parsed)
        {
            try
            {
                var year = Convert.ToInt32(parsed.Groups["year"].Value);
                var month = Convert.ToInt32(parsed.Groups["month"].Value);
                var day = Convert.ToInt32(parsed.Groups["day"].Value);
                var hour = Convert.ToInt32(parsed.Groups["hour"].Value);
                var minute = Convert.ToInt32(parsed.Groups["minute"].Value);
                var second = Convert.ToInt32(parsed.Groups["second"].Value);
                return new DateTime(year, month, day, hour, minute, second);
            }
            catch (FormatException)
            {
                return null;
            }
            catch (OverflowException)
            {
                return null;
            }
        }
    }
}
