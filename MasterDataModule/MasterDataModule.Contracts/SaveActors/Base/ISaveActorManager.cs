using System.Data.Entity;

namespace MasterDataModule.Contracts.SaveActors.Base
{
    public interface ISaveActorManager
    {
        void DoBeforeSaveAction(object entity, EntityState state);
    }
}