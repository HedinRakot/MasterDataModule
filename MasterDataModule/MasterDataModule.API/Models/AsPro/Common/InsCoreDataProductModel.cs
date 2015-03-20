using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsCoreDataProduct"/> entity
    /// </summary>
    [DataContract]
    public class InsCoreDataProductModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.ProductNumber"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string productNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.IsNextInspectionProduct"/> entity
        /// </summary>
        [DataMember]
        public bool? isNextInspectionProduct{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.IsProvisionCostMayBeCalculated"/> entity
        /// </summary>
        [DataMember]
        public bool? isProvisionCostMayBeCalculated{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.PriceReportRequired"/> entity
        /// </summary>
        [DataMember]
        public bool? priceReportRequired{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.InsProductTypeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int insProductTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.InsProductObjectClassId"/> entity
        /// </summary>
        [DataMember]
        public int? insProductObjectClassId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.InsProductObjectTypeId"/> entity
        /// </summary>
        [DataMember]
        public int? insProductObjectTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.InsProductMaterialGroupId"/> entity
        /// </summary>
        [DataMember]
        public int? insProductMaterialGroupId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.InsProductClassId"/> entity
        /// </summary>
        [DataMember]
        public int? insProductClassId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.InsCoreDataProductGroupId"/> entity
        /// </summary>
        [DataMember]
        public int? insCoreDataProductGroupId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.IsIngener"/> entity
        /// </summary>
        [DataMember]
        public bool? isIngener{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.IsProductive"/> entity
        /// </summary>
        [DataMember]
        public int isProductive{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.IsKmGeld"/> entity
        /// </summary>
        [DataMember]
        public bool isKmGeld{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.IsOtherMaterial"/> entity
        /// </summary>
        [DataMember]
        public bool isOtherMaterial{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.IsTrip"/> entity
        /// </summary>
        [DataMember]
        public bool isTrip{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.ReusageType"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int reusageType{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.InsTaxCodeId"/> entity
        /// </summary>
        [DataMember]
        public int? insTaxCodeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProduct.OldProductNumber"/> entity
        /// </summary>
        [DataMember]
        public string oldProductNumber{ get; set; }

    }
}
