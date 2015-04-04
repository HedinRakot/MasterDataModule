using System.Data.Entity.ModelConfiguration;
using MasterDataModule.Contracts.Entities.Monitor;

namespace MasterDataModule.Lib.Data
{
    internal sealed class MasterDataWcfInfoMapping : EntityTypeConfiguration<MasterDataWcfInfo>
    {
    public static readonly MasterDataWcfInfoMapping Instance = new MasterDataWcfInfoMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="OrdRecognitionTypeMapping" /> class.
        /// </summary>
    private MasterDataWcfInfoMapping()
        {

            ToTable("MASTER_DATA_WCF_INFO", "dbo");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Name)
                .HasColumnName(MasterDataWcfInfo.Fields.Name)
                .IsUnicode();
                

            Property(t => t.TimeoutChecking)
                .HasColumnName(MasterDataWcfInfo.Fields.TimeoutChecking);
            
            Property(t => t.WsdlPath)
                .HasColumnName(MasterDataWcfInfo.Fields.WsdlPath);

            Property(t => t.DeleteDate)
            .HasColumnName(MasterDataWcfInfo.Fields.DeleteDate);

            Property(t => t.ChangeDate)
                .HasColumnName(MasterDataWcfInfo.Fields.ChangeDate);

            Property(t => t.CreateDate)
            .HasColumnName(MasterDataWcfInfo.Fields.CreateDate);

         
            //Relationships
        }
    }
    
}
