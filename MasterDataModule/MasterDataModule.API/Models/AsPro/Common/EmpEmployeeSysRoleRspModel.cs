using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="EmpEmployeeSysRoleRsp"/> entity
    /// </summary>
    [DataContract]
    public class EmpEmployeeSysRoleRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="EmpEmployeeSysRoleRsp.EmpEmployeeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int empEmployeeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployeeSysRoleRsp.SysRoleId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int sysRoleId{ get; set; }

    }
}
