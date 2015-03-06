using System;
using System.Collections.Generic;

namespace TuevSued.V1.IT.FE.CommonObjects.Interfaces
{
    /// <summary>
    /// Session parameters storage
    /// </summary>
    public interface ISessionService
    {
        /// <summary>
        /// Occurs when session is changed
        /// </summary>
        event EventHandler SessionChanged;
        /// <summary>
        /// Owner Organization Id
        /// </summary>
        Guid SessionGuid { get; set; }
        /// <summary>
        /// Owner Organization Id
        /// </summary>
        int? OwnerOrgId { get; set; }
        /// <summary>
        /// Visibility Organization Id
        /// </summary>
        int? VisibilityOrgId { get; set; }
        /// <summary>
        /// Current employee Id
        /// </summary>
        int? EmployeeId { get; set; }
        /// <summary>
        /// Current user name
        /// </summary>
        string UserName { get; set; }
        /// <summary>
        /// Current TSC Id
        /// </summary>
        int? TscId { get; set; }
        /// <summary>
        /// Contains index of tab for return after reload page
        /// </summary>
        int? TabIndex { get; set; }
        /// <summary>
        /// Name of TSC
        /// </summary>
        string TSCName { get; set; }
        /// <summary>
        /// User title, last name + name
        /// </summary>
        string UserTitle { get; set; }
        
        /// <summary>
        /// Shows if session under web
        /// </summary>
        bool IsWebClient { get; }

        /// <summary>
        /// Clear session
        /// </summary>
        void Clear();

        /// <summary>
        /// Fills session fields from xml
        /// </summary>
        /// <param name="xml">xml string</param>
        void LoadFromXml(string xml);

        /// <summary>
        /// Represents object like xml string
        /// </summary>
        /// <returns>xml string</returns>
        string GetXmlString();
    }
}
