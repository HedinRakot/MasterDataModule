using System;
using System.Runtime.Serialization;

namespace MasterDataModule.API.Models.Monitor
{
    public class WcfServiceStatusModel : BaseModel
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public int? checkStatus { get; set; }

        [DataMember]
        public DateTime? checkDate { get; set; }

        [DataMember]
        public int? attempt { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public string wsdlPath { get; set; }

        [DataMember]
        public int? logTypeInfoId { get; set; }
    }
}
