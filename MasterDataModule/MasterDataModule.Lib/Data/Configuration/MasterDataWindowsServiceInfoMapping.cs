using MasterDataModule.Contracts.Entities.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data.Configuration
{
    /// <summary>
    ///     Mappping table dbo.MASTER_DATA_WINDOWS_SERVICE_INFO to entity <see cref="MasterDataWindowsServiceInfo"/>
    /// </summary>
    internal sealed class MasterDataWindowsServiceInfoMapping: EntityTypeConfiguration<MasterDataWindowsServiceInfo>
    {
        
        public static readonly MasterDataWindowsServiceInfoMapping Instance = new MasterDataWindowsServiceInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="MasterDataWindowsServiceInfoMapping" /> class.
        /// </summary>
        private MasterDataWindowsServiceInfoMapping()
        {

            ToTable("MASTER_DATA_WINDOWS_SERVICE_INFO", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.Name)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.Name)
                .IsRequired()
                .IsUnicode();

            Property(t => t.MachineName)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.MachineName)
                .IsRequired()
                .IsUnicode();

            Property(t => t.ServiceName)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.ServiceName)
                .IsRequired()
                .IsUnicode();

            Property(t => t.TimeoutChecking)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.TimeoutChecking)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.CreateDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.FromDate)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.ToDate)
                .IsRequired();

            Property(t => t.LogTypeInfoId)
                .HasColumnName(MasterDataWindowsServiceInfo.Fields.LogTypeInfoId);


            //Relationships
            HasOptional(m => m.LogTypeInfo)
                .WithMany(l => l.MasterDataWindowsServiceInfos)
                .HasForeignKey(t => t.LogTypeInfoId);
        }
    }
}
