using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="EmpEmployeeTopEmployeeRsp"/> entity
    /// </summary>
    [DataContract]
    public class EmpEmployeeTopEmployeeRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="EmpEmployeeTopEmployeeRsp.EmpEmployeeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int empEmployeeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployeeTopEmployeeRsp.TopEmployeeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int topEmployeeId{ get; set; }

    }
}
