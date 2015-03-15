using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamRoom"/> entity
    /// </summary>
    [DataContract]
    public class ExamRoomModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamRoom.RoomNumber"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public long roomNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.PlaceAmount"/> entity
        /// </summary>
        [DataMember]
        public int placeAmount{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.OrgOrganizationalUnitId"/> entity
        /// </summary>
        [DataMember]
        public int orgOrganizationalUnitId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.Name1"/> entity
        /// </summary>
        [DataMember]
        public string name1{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.Name2"/> entity
        /// </summary>
        [DataMember]
        public string name2{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.Name3"/> entity
        /// </summary>
        [DataMember]
        public string name3{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.StreetHouseNumber"/> entity
        /// </summary>
        [DataMember]
        public string streetHouseNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.ZipCode"/> entity
        /// </summary>
        [DataMember]
        public string zipCode{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.ZipBox"/> entity
        /// </summary>
        [DataMember]
        public string zipBox{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.Box"/> entity
        /// </summary>
        [DataMember]
        public string box{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.City"/> entity
        /// </summary>
        [DataMember]
        public string city{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.Phone1"/> entity
        /// </summary>
        [DataMember]
        public string phone1{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.Fax"/> entity
        /// </summary>
        [DataMember]
        public string fax{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.Email"/> entity
        /// </summary>
        [DataMember]
        public string email{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRoom.SysCountryId"/> entity
        /// </summary>
        [DataMember]
        public int sysCountryId{ get; set; }

    }
}
