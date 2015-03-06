using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;
using System;
namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData
{
    [DataContract]
    public class EmpEmployeeModel : BaseModel, ISystemModelFields
	{
        [DataMember]
        public string userName { get; set; }
        [DataMember]
        public string windowsUserName { get; set; }
        [DataMember]
        [Required]
        public string name { get; set; }
        [DataMember]
        public string lastName { get; set; }
        [DataMember]
        public string middleName { get; set; }
        [DataMember]
        public DateTime fromDate { get; set; }
        [DataMember]
        public DateTime toDate { get; set; }
        [DataMember]
        public string personalNumber { get; set; }
        [DataMember]
        public string domain { get; set; }
        [DataMember]
        public bool isSSOAllowed { get; set; }
        [DataMember]
        public bool isPasswordLoginAllowed { get; set; }
        [DataMember]
        public bool isEmergencyLoginAllowed { get; set; }
        [DataMember]
        public int? empCoreAddressId { get; set; }
        [DataMember]
        public string comment { get; set; }
        [DataMember]
        public int sexType { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public DateTime birthDate { get; set; }
	}
}
