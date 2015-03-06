using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Base;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.DriverLicenceMasterData
{
    /// <summary>
    /// 
    /// </summary>
    public class LegalBasisManager : EntityManager<LegalBasis, int>, ILegalBasisManager
	{
        public LegalBasisManager(IFeEntities context) :
            base(context)
        {
        }
	}
}
