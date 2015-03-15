using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrdRecognitionAreaOfWorkRsp"/> entity
    /// </summary>
    [DataContract]
    public class OrdRecognitionAreaOfWorkRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrdRecognitionAreaOfWorkRsp.OrdRecognitionId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int ordRecognitionId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdRecognitionAreaOfWorkRsp.OrdAreaOfWorkId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int ordAreaOfWorkId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdRecognitionAreaOfWorkRsp.Priority"/> entity
        /// </summary>
        [DataMember]
        public int priority{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdRecognitionAreaOfWorkRsp.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdRecognitionAreaOfWorkRsp.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
