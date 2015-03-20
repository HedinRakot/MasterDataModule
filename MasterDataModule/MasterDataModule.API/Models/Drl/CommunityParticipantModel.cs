using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="CommunityParticipant"/> entity
    /// </summary>
    [DataContract]
    public class CommunityParticipantModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="CommunityParticipant.DriverSchoolIdParticipant"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int driverSchoolIdParticipant{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CommunityParticipant.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CommunityParticipant.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CommunityParticipant.DriverSchoolIdLead"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int driverSchoolIdLead{ get; set; }

    }
}
