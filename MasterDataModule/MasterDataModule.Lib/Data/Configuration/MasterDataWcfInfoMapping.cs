using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_WCF_INFO to entity <see cref="MasterDataWcfInfo"/>
    /// </summary>
    internal sealed class MasterDataWcfInfoMapping: EntityTypeConfiguration<MasterDataWcfInfo>
    {
        
        public static readonly MasterDataWcfInfoMapping Instance = new MasterDataWcfInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataWcfInfoMapping" /> class.
        /// </summary>
        private MasterDataWcfInfoMapping()
        {

            ToTable("MASTER_DATA_WCF_INFO", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataWcfInfo.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(MasterDataWcfInfo.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.WsdlPath)
                .HasColumnName(MasterDataWcfInfo.Fields.WsdlPath)
                .IsRequired()
                .IsUnicode();

            Property(t => t.TimeoutChecking)
                .HasColumnName(MasterDataWcfInfo.Fields.TimeoutChecking)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataWcfInfo.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataWcfInfo.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataWcfInfo.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(MasterDataWcfInfo.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(MasterDataWcfInfo.Fields.ToDate)
                .IsRequired();

            Property(t => t.LogTypeInfoId)
                .HasColumnName(MasterDataWcfInfo.Fields.LogTypeInfoId);


            //Relationships
            HasOptional(m => m.LogTypeInfo)
                .WithMany(l => l.MasterDataWcfInfos)
                .HasForeignKey(t => t.LogTypeInfoId);
        }
    }
}
