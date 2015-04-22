using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Log
{
    /// <summary>
    /// Class for creating reports about messages in log files
    /// </summary>
    public sealed class LogReportFactory
    {
        private const string ErrorLogReportTemplate = "Templates/ErrorReportTemplate.xslt";
        private static readonly XslCompiledTransform ErrorTransform = new XslCompiledTransform();
        private static readonly XmlSerializer ErrorLogModelSerializer;

        static LogReportFactory()
        {
            ErrorTransform.Load(ErrorLogReportTemplate);
            ErrorLogModelSerializer = new XmlSerializer(typeof(ErrorLogModel));
        }

        /// <summary>
        /// Gets HTML report for list of errors
        /// </summary>
        public string CreateErrorReport(IList<ApplicationLogs> errors, LogTypeInfo logTypeInfo)
        {
            var errorLogModel = new ErrorLogModel
            {
                ErrorModels = errors.Select(e => new ErrorModel {Message = e.Message, Date = e.Date.HasValue? e.Date.Value.ToString(CultureInfo.CurrentCulture):""}).ToArray(),
                LogName = logTypeInfo.FileName
            };

            var writer = new StringWriter();
            ErrorLogModelSerializer.Serialize(writer, errorLogModel);

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(writer.GetStringBuilder().ToString());
            
            var resultWriter = new StringWriter();
            var resultXmlWriter = new XmlTextWriter(resultWriter);

            ErrorTransform.Transform(xmlDoc, resultXmlWriter);

            return resultWriter.ToString();
        }

        #region Nested types

        [XmlRoot("ErrorLogModel")]
        public class ErrorLogModel
        {
            [XmlArray("ErrorModels")]
            public ErrorModel[] ErrorModels { get; set; }
            [XmlElement("LogName")]
            public string LogName { get; set; }
        }

        public class ErrorModel
        {
            [XmlElement("Message")]
            public string Message { get; set; }

            [XmlElement("Date")]
            public string Date { get; set; }
        }

        #endregion Nested types
    }
}
