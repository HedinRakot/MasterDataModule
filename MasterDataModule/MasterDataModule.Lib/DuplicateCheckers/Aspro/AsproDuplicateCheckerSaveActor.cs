using MasterDataModule.Contracts.SaveActors.Aspro;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;

namespace MasterDataModule.Lib.DuplicateCheckers.Aspro
{
    public sealed class AsproDuplicateCheckerSaveActor : BaseDuplicateCheckerSaveActor<IAsProDuplicateChecker>, IAsProSaveActor
    {
        public AsproDuplicateCheckerSaveActor(IAsProDuplicateChecker[] checkers) : base(checkers)
        {
        }
    }
}
