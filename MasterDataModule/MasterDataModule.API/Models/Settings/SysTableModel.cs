using MasterDataModule.Contracts.Entities;
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
        ///     Model property for <see cref="SysTable.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysTable.EditMode"/> entity
        /// </summary>
        [DataMember]
        public int editMode{ get; set; }

    }
}
