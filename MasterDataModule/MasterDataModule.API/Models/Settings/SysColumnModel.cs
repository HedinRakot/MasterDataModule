using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="SysColumn"/> entity
    /// </summary>
    [DataContract]
    public class SysColumnModel : BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SysColumn.SysTableId"/> entity
        /// </summary>
        [DataMember]
        public int sysTableId { get; set; }
        /// <summary>
        ///     Model property for <see cref="SysColumn.Description"/> entity
        /// </summary>
        [DataMember]
        public string description { get; set; }
        /// <summary>
        ///     Model property for <see cref="SysColumn.ReadOnly"/> entity
        /// </summary>
        [DataMember]
        public bool readOnly { get; set; }

    }
}
