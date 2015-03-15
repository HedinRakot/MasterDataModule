using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsPfpInspectionTypePfpPositionRsp"/> entity
    /// </summary>
    [DataContract]
    public class InsPfpInspectionTypePfpPositionRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsPfpInspectionTypePfpPositionRsp.InsPfpPositionId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int insPfpPositionId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpInspectionTypePfpPositionRsp.InsPfpInspectionTypeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int insPfpInspectionTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpInspectionTypePfpPositionRsp.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsPfpInspectionTypePfpPositionRsp.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
