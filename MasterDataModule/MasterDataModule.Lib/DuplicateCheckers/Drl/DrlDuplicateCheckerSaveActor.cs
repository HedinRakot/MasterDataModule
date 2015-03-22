using MasterDataModule.Contracts.SaveActors.Drl;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;

namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    public sealed class DrlDuplicateCheckerSaveActor : BaseDuplicateCheckerSaveActor<IDrlDuplicateChecker>, IDrlSaveActor
    {
        public DrlDuplicateCheckerSaveActor(IDrlDuplicateChecker[] checkers) : base(checkers)
        {
        }
    }
}
