using System;
using System.Runtime.Serialization;

namespace MasterDataModule.API.Models.Monitor
{
    public class MasterDataWcfInfoModel : BaseModel
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public int timeoutChecking { get; set; }
        

        [DataMember]
        public string wsdlPath { get; set; }
    }
}
