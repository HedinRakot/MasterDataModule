using MasterDataModule.Contracts.SaveActors.Aspro;
using MasterDataModule.Lib.Data.SaveActors.Base;

namespace MasterDataModule.Lib.Data.SaveActors.AsPro
{
    public sealed class AsProSaveActorManager : SaveActorManager<IAsProSaveActor>, IAsProSaveActorManager
    {
        public AsProSaveActorManager(IAsProSaveActor[] saveActors): base (saveActors)
        {
        }
    }
}