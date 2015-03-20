using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="CoreDataProduct"/> entity
    /// </summary>
    public partial class CoreDataProductModel
    {
        [DataMember]
        public string productName { get; set; }
    }
}
