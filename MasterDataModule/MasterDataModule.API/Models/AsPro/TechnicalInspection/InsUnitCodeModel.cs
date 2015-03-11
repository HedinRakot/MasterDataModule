using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsUnitCode"/> entity
    /// </summary>
    [DataContract]
    public class InsUnitCodeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsUnitCode.OrgAccountingAreaId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int orgAccountingAreaId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsUnitCode.OrdFederalStateId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int ordFederalStateId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsUnitCode.OrdAreaOfWorkId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int ordAreaOfWorkId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsUnitCode.UnitCode"/> entity
        /// </summary>
        [DataMember]
        public string unitCode{ get; set; }

    }
}
