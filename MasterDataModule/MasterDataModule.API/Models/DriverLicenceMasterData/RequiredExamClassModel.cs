using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;
using System;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData
{
    [DataContract]
    public class RequiredExamClassModel : BaseModel
	{
        [Required]
        [DataMember]
        public int examClassId { get; set; }
        [Required]
        [DataMember]
        public int requiredExamClassId { get; set; }
        [DataMember]
        public DateTime fromDate { get; set; }
        [DataMember]
        public DateTime toDate { get; set; }
	}
}
