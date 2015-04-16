using System;
using System.Runtime.Serialization;

namespace MasterDataModule.API.Models.Monitor
{
    public class ApplicationLogToShowModel : BaseModel
    {
        [DataMember]
        public string fileName { get; set; }

        [DataMember]
        public int logLevel { get; set; }

        [DataMember]
        public DateTime? messageDate { get; set; }
        
        [DataMember]
        public string message { get; set; }
        
        [DataMember]
        public int? logTypeInfoId { get; set; }
    }
}
