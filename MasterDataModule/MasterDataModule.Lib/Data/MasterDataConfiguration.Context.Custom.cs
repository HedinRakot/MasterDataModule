using System.Data.Entity;
using MasterDataModule.Contracts.SaveActors.Base;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     MasterDataConfiguration Entities
    /// </summary>
    [DbConfigurationType(typeof(MasterDataConfigurationConfiguration))]
    public partial class MasterDataConfigurationEntities: EntitiesBase
    {
        /// <summary>
        /// </summary>
        /// <param name="saveActorManager"></param>
        /// <param name="connectionString"></param>
        public MasterDataConfigurationEntities(ISaveActorManager saveActorManager, string connectionString)
            : base(saveActorManager, connectionString)
        {
        }

        static MasterDataConfigurationEntities()
        {
            Database.SetInitializer<MasterDataConfigurationEntities>(null);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataConfigurationEntities" /> class.
        /// </summary>
        public MasterDataConfigurationEntities(ISaveActorManager saveActorManager)
            : base(saveActorManager, "name=MasterDataConfigurationEntities")
        {
        }
    }
}