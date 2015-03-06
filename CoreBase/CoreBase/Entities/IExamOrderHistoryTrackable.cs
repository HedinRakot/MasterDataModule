using System.Collections.Generic;

namespace TuevSued.V1.IT.FE.CommonObjects.Entities
{
    /// <summary>
    /// Is entity trackable for workflow history
    /// </summary>
    public interface IExamOrderHistoryTrackable
    {
        /// <summary>
        /// Entity table name
        /// </summary>
        string TableName { get; }
        /// <summary>
        /// Returns trackable properties and mapped column names
        /// </summary>
        Dictionary<string, string> TrackableProperties { get; }
    }
}