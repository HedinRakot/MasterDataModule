using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;
using System;
namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData
{
    [DataContract]
    public class InsCoreDataProductModel : BaseModel, ISystemModelFields
	{
        [DataMember]
        [Required]
        public string name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public DateTime fromDate { get; set; }
        [DataMember]
        public DateTime toDate { get; set; }
        [DataMember]
        public string productNumber { get; set; }
	}
}
