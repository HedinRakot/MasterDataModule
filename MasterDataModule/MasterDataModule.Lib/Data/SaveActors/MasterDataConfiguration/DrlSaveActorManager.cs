using System.Collections.Generic;
using MasterDataModule.Contracts.SaveActors.MasterDataConfiguration;
using MasterDataModule.Lib.Data.SaveActors.Base;

namespace MasterDataModule.Lib.Data.SaveActors.MasterDataConfiguration
{
    public sealed class MasterDataConfigurationSaveActorManager : SaveActorManager<IMasterDataConfigurationSaveActor>, IMasterDataConfigurationSaveActorManager
    {
        public MasterDataConfigurationSaveActorManager(IMasterDataConfigurationSaveActor[] actors)
            : base(actors)
        {
        }
    }
}
