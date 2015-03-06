using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;
using System;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData
{
    [DataContract]
    public class CoreDataProductClassBasisModel : BaseModel
	{
        [Required]
        [DataMember]
        public int coreDataProductId { get; set; }
        [DataMember]
        public int examClassId { get; set; }
        [Required]
        [DataMember]
        public int legalBasisId { get; set; }
        [DataMember]
        public DateTime fromDate { get; set; }
        [DataMember]
        public DateTime toDate { get; set; }
        [DataMember]
        public int sortOrder { get; set; }
	}
}
