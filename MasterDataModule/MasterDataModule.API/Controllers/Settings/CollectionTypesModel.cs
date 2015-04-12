using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     CollectionTypesModel class
    /// </summary>
    public partial class CollectionTypesModel
    {
        public bool Role { get; set;}
        public bool Permission { get; set;}
        public bool MasterDataSubscribers { get; set;}
        public bool MasterDataNotifications { get; set;}
    }
}
