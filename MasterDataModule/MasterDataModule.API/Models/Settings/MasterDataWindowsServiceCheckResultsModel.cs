using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataWindowsServiceCheckResults"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataWindowsServiceCheckResultsModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceCheckResults.CheckStatus"/> entity
        /// </summary>
        [DataMember]
        public int? checkStatus{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceCheckResults.CheckDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? checkDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceCheckResults.Message"/> entity
        /// </summary>
        [DataMember]
        public string message{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceCheckResults.Attempt"/> entity
        /// </summary>
        [DataMember]
        public int? attempt{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceCheckResults.MasterDataWindowsServiceInfoId"/> entity
        /// </summary>
        [DataMember]
        public int masterDataWindowsServiceInfoId{ get; set; }

    }
}
