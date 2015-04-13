using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     CollectionTypesModel class
    /// </summary>
    public partial class CollectionTypesModel
    {
        public bool MasterDataWcfInfo { get; set;}
        public bool MasterDataSiteInfo { get; set;}
        public bool MasterDataJobInfo { get; set;}
        public bool MasterDataWindowsServiceInfo { get; set;}
        public bool Role { get; set;}
        public bool Permission { get; set;}
        public bool MasterDataSubscribers { get; set;}
        public bool MasterDataNotifications { get; set;}
    }
}
