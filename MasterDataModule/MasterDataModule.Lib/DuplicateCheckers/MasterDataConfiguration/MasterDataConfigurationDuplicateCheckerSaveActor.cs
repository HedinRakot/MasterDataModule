using MasterDataModule.Contracts.SaveActors.MasterDataConfiguration;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;

namespace MasterDataModule.Lib.DuplicateCheckers.MasterDataConfiguration
{
    public sealed class MasterDataConfigurationDuplicateCheckerSaveActor : BaseDuplicateCheckerSaveActor<IMasterDataConfigurationDuplicateChecker>, IMasterDataConfigurationSaveActor
    {
        public MasterDataConfigurationDuplicateCheckerSaveActor(IMasterDataConfigurationDuplicateChecker[] checkers)
            : base(checkers)
        {
        }
    }
}
