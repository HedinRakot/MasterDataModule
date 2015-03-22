using System.Data.Entity;
using MasterDataModule.Contracts.SaveActors.Base;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     FeEntities
    /// </summary>
    [DbConfigurationType(typeof (FeEntitiesConfiguration))]
    public partial class DrlEntities: EntitiesBase
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public DrlEntities(ISaveActorManager saveActorManager, string connectionString)
            : base(saveActorManager, connectionString)
        {
        }

        static DrlEntities()
        {
            Database.SetInitializer<DrlEntities>(null);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DrlEntities" /> class.
        /// </summary>
        public DrlEntities(ISaveActorManager saveActorManager)
            : base(saveActorManager, "name=FeEntities")
        {
        }


    }
}