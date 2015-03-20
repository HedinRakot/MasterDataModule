using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrgOrganizationalUnit"/> entity
    /// </summary>
    [DataContract]
    public class OrgOrganizationalUnitModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.OrgNumber"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int orgNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.Abbr"/> entity
        /// </summary>
        [DataMember]
        public string abbr{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.LocationAbbr"/> entity
        /// </summary>
        [DataMember]
        public string locationAbbr{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.SysLocationId"/> entity
        /// </summary>
        [DataMember]
        public int? sysLocationId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.OrgTypeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int orgTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.EmailFrom"/> entity
        /// </summary>
        [DataMember]
        public string emailFrom{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.EmailTo"/> entity
        /// </summary>
        [DataMember]
        public string emailTo{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.IsEgdokPrintAlways"/> entity
        /// </summary>
        [DataMember]
        public bool isEgdokPrintAlways{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgOrganizationalUnit.OrgAccountingAreaId"/> entity
        /// </summary>
        [DataMember]
        public int? orgAccountingAreaId{ get; set; }

    }
}
