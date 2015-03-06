using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;
using TuevSued.V1.IT.FE.DataAccess.Interfaces;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Common;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Base;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Common
{
    public class OrgOrganizationalUnitManager : EntityManager<OrgOrganizationalUnit, int>, IOrgOrganizationalUnitManager
    {
        public OrgOrganizationalUnitManager(IASProEntities context) : base(context)
        {
        }
    }
}
