using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;
using System;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData
{
    [DataContract]
    public class InclusiveExamClassModel : BaseModel
	{
        [Required]
        [DataMember]
        public int examClassId { get; set; }
        [Required]
        [DataMember]
        public int inclusiveExamClassId { get; set; }
        [DataMember]
        public DateTime fromDate { get; set; }
        [DataMember]
        public DateTime toDate { get; set; }
        [DataMember]
        public bool isConditional { get; set; }
	}
}
