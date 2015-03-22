using System.Data.Entity;

namespace MasterDataModule.Contracts.SaveActors.Base
{
    public interface ISaveActor
    {
        bool NeedDoAction(object entity, EntityState state);
        void DoAction(object entity, EntityState state);
    }
}