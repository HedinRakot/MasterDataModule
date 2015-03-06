using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Base;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class InsCoreDataProductLocalizationManager : EntityManager<InsCoreDataProductLocalization, int>, IInsCoreDataProductLocalizationManager
	{
        public InsCoreDataProductLocalizationManager(IASProEntities context) :
            base(context)
        {
        }
	}
}
