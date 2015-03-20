using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     CollectionTypesModel class
    /// </summary>
    public partial class CollectionTypesModel
    {
        public bool SysLanguage { get; set;}
        public bool SysLocation { get; set;}
        public bool OrgAccountingArea { get; set;}
        public bool OrdFederalState { get; set;}
        public bool SysCountry { get; set;}
        public bool OrgType { get; set;}
        public bool OrgOrganizationalUnit { get; set;}
    }
}
