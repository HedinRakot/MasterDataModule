using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamStation"/> entity
    /// </summary>
    [DataContract]
    public class ExamStationModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamStation.OrdFederalStateId"/> entity
        /// </summary>
        [DataMember]
        public int? ordFederalStateId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamStation.Place"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string place{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamStation.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamStation.SortOrder"/> entity
        /// </summary>
        [DataMember]
        public int sortOrder{ get; set; }

    }
}
