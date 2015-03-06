using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;
using System;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData
{
    [DataContract]
    public class EmpEmployeeSysRoleRspModel : BaseModel, ISystemModelFields
	{
        [Required]
        [DataMember]
        public int empEmployeeId { get; set; }
        [Required]
        [DataMember]
        public int sysRoleId { get; set; }
        [DataMember]
        public DateTime fromDate { get; set; }
        [DataMember]
        public DateTime toDate { get; set; }
	}
}
