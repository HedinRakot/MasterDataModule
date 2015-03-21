using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="EmpEmployeeOrgOrganizationalUnitRsp"/> entity
    /// </summary>
    [DataContract]
    public partial class EmpEmployeeOrgOrganizationalUnitRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="EmpEmployeeOrgOrganizationalUnitRsp.EmpEmployeeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int empEmployeeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployeeOrgOrganizationalUnitRsp.OrgOrganizationalUnitId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int orgOrganizationalUnitId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployeeOrgOrganizationalUnitRsp.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployeeOrgOrganizationalUnitRsp.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
