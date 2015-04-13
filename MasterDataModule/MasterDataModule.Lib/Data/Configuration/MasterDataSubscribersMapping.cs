using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_SUBSCRIBERS to entity <see cref="MasterDataSubscribers"/>
    /// </summary>
    internal sealed class MasterDataSubscribersMapping: EntityTypeConfiguration<MasterDataSubscribers>
    {
        
        public static readonly MasterDataSubscribersMapping Instance = new MasterDataSubscribersMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataSubscribersMapping" /> class.
        /// </summary>
        private MasterDataSubscribersMapping()
        {

            ToTable("MASTER_DATA_SUBSCRIBERS", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataSubscribers.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Email)
                .HasColumnName(MasterDataSubscribers.Fields.Email)
                .IsRequired()
                .IsUnicode();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataSubscribers.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataSubscribers.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataSubscribers.Fields.DeleteDate);

            Property(t => t.FromDate)
                .HasColumnName(MasterDataSubscribers.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(MasterDataSubscribers.Fields.ToDate)
                .IsRequired();


            //Relationships
        }
    }
}
