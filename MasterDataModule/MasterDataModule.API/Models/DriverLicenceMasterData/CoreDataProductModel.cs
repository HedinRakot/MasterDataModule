using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;
using System;
namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData
{
    [DataContract]
    public class CoreDataProductModel : BaseModel, ISystemModelFields
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
        public int minAge { get; set; }
        [DataMember]
        public int? maxAge { get; set; }
        [DataMember]
        public int examType { get; set; }
        [DataMember]
        public int insCoreDataProductId { get; set; }
        [DataMember]
        public string insCoreDataProductName { get; set; }
        [DataMember]
        public short priorTimeInMonths { get; set; }
        [DataMember]
        public short expirationInMonth { get; set; }
        [DataMember]
        public short repeatTimeInDays { get; set; }
        [DataMember]
        public short repeatTimeInDaysReduced { get; set; }
        [DataMember]
        public bool trainingCertFlag { get; set; }
        [DataMember]
        public bool resultFlag { get; set; }
        [DataMember]
        public bool multiplyFlag { get; set; }
        [DataMember]
        public bool isMofaPrint { get; set; }
        [DataMember]
        public bool isAdditionalProduct { get; set; }
        [DataMember]
        public bool isPrepaymentRequired { get; set; }
        [DataMember]
        public bool isMandatory { get; set; }
	}
}
