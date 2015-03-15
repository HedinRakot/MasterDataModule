using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="MeetingPointOrganizationalUnit"/> entity
    /// </summary>
    [DataContract]
    public class MeetingPointOrganizationalUnitModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MeetingPointOrganizationalUnit.MeetingPointId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int meetingPointId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MeetingPointOrganizationalUnit.OrgOrganizationalUnitId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int orgOrganizationalUnitId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MeetingPointOrganizationalUnit.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MeetingPointOrganizationalUnit.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
