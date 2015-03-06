using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;
using System;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData
{
    [DataContract]
    public class CoreDataProductLocalizationModel : BaseModel
	{
        [DataMember]
        [Required]
        public string name { get; set; }
        [DataMember]
        public string description { get; set; }
        [Required]
        [DataMember]
        public int coreDataProductId { get; set; }
        
        [Required]
        [DataMember]
        public int sysLanguageId { get; set; }
        [DataMember]
        public DateTime fromDate { get; set; }
        [DataMember]
        public DateTime toDate { get; set; }
	}
}
