using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="SysTable"/> entity
    /// </summary>
    [DataContract]
    public partial class SysTableModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SysTable.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysTable.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysTable.EditMode"/> entity
        /// </summary>
        [DataMember]
        public int editMode{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysTable.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysTable.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
