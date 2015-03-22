using System.Data.Entity;
using MasterDataModule.Contracts.SaveActors.Aspro;
using MasterDataModule.Contracts.SaveActors.Base;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    /// ASProEntities
    /// </summary>
    [DbConfigurationType(typeof(AsProEntitiesConfiguration))]
    public partial class AsProEntities : EntitiesBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="saveActorManager"></param>
        /// <param name="connectionString"></param>
        public AsProEntities(ISaveActorManager saveActorManager, string connectionString)
            : base(saveActorManager, connectionString)
        {
        }

        static AsProEntities()
        {
            Database.SetInitializer<AsProEntities>(null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsProEntities"/> class.
        /// </summary>
        public AsProEntities(IAsProSaveActorManager saveActorManager)
            : base(saveActorManager, "name=ASProEntities")
        {
        }
    }
}