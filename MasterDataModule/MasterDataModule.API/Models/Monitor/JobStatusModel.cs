using System;
using System.Runtime.Serialization;

namespace MasterDataModule.API.Models.Monitor
{
    public class JobStatusModel : BaseModel
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public int? checkStatus { get; set; }

        [DataMember]
        public DateTime? checkDate { get; set; }

        [DataMember]
        public DateTime? lastRunTime { get; set; }

        [DataMember]
        public string jobName { get; set; }

        [DataMember]
        public int? logTypeInfoId { get; set; }

    }
}
