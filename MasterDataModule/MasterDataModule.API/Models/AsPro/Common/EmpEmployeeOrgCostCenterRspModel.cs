using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="EmpEmployeeOrgCostCenterRsp"/> entity
    /// </summary>
    [DataContract]
    public partial class EmpEmployeeOrgCostCenterRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="EmpEmployeeOrgCostCenterRsp.EmpEmployeeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int empEmployeeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployeeOrgCostCenterRsp.OrgCostCenterId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int orgCostCenterId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployeeOrgCostCenterRsp.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployeeOrgCostCenterRsp.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
