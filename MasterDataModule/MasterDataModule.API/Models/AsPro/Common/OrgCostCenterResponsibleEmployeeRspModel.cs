using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrgCostCenterResponsibleEmployeeRsp"/> entity
    /// </summary>
    [DataContract]
    public class OrgCostCenterResponsibleEmployeeRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrgCostCenterResponsibleEmployeeRsp.OrgCostCenterId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int orgCostCenterId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterResponsibleEmployeeRsp.EmpEmployeeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int empEmployeeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterResponsibleEmployeeRsp.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterResponsibleEmployeeRsp.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
