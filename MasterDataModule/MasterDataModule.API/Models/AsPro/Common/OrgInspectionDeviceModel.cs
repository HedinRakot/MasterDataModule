using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrgInspectionDevice"/> entity
    /// </summary>
    [DataContract]
    public class OrgInspectionDeviceModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.DebitorCustomerNumber"/> entity
        /// </summary>
        [DataMember]
        public string debitorCustomerNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.Identification"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string identification{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.NewIdentification"/> entity
        /// </summary>
        [DataMember]
        public string newIdentification{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.OldIdentification"/> entity
        /// </summary>
        [DataMember]
        public string oldIdentification{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.Type"/> entity
        /// </summary>
        [DataMember]
        public string type{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.SerialNumber"/> entity
        /// </summary>
        [DataMember]
        public string serialNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.LastInspectionDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? lastInspectionDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.LastInspectionResult"/> entity
        /// </summary>
        [DataMember]
        public string lastInspectionResult{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.InspectionDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? inspectionDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.InspectionInterval"/> entity
        /// </summary>
        [DataMember]
        public int? inspectionInterval{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInspectionDevice.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
