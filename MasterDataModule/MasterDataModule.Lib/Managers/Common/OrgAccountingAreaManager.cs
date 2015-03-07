using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Common;
using TuevSued.V1.IT.FE.Entities.MasterDataModule.Common;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Base;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Common
{
    public class OrgAccountingAreaManager : EntityManager<OrgAccountingArea, int>, IOrgAccountingAreaManager
    {
        public OrgAccountingAreaManager(IASProEntities context) : base(context)
        {
        }
    }
}
