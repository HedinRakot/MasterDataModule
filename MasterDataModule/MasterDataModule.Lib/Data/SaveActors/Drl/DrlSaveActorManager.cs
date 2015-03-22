using System.Collections.Generic;
using MasterDataModule.Contracts.SaveActors.Drl;
using MasterDataModule.Lib.Data.SaveActors.Base;

namespace MasterDataModule.Lib.Data.SaveActors.Drl
{
    public sealed class DrlSaveActorManager : SaveActorManager<IDrlSaveActor>, IDrlSaveActorManager
    {
        public DrlSaveActorManager(IDrlSaveActor[] actors) : base(actors)
        {
        }
    }
}
