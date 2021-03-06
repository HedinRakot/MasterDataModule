//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;    
using System.Data.Entity.ModelConfiguration;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
        /// <summary>
        /// Database mapping for <see cref="CoreDataProductClassBasis"/> to table DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP
        /// </summary>
        internal sealed class CoreDataProductClassBasisMapping : EntityTypeConfiguration<CoreDataProductClassBasis>
        {
    	    public static readonly CoreDataProductClassBasisMapping Instance = new CoreDataProductClassBasisMapping();
    	    /// <summary>
            /// Instance constructor
            /// </summary>
            private CoreDataProductClassBasisMapping()
            {
                // Primary Key
                this.HasKey(t => t.Id);
    
                // Properties
                this.Property(t => t.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
                this.Property(t => t.CreateDate)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
                // Table & Column Mappings
                this.ToTable("DRL_CORE_DATA_PRODUCT_CLASS_BASIS_RSP", "DATA");
                this.Property(t => t.Id).HasColumnName(CoreDataProductClassBasis.Fields.Id);
                this.Property(t => t.ExamClassId).HasColumnName(CoreDataProductClassBasis.Fields.ExamClassId);
                this.Property(t => t.CoreDataProductId).HasColumnName(CoreDataProductClassBasis.Fields.CoreDataProductId);
                this.Property(t => t.LegalBasisId).HasColumnName(CoreDataProductClassBasis.Fields.LegalBasisId);
                this.Property(t => t.CreateDate).HasColumnName(CoreDataProductClassBasis.Fields.CreateDate);
                this.Property(t => t.ChangeDate).HasColumnName(CoreDataProductClassBasis.Fields.ChangeDate);
                this.Property(t => t.OwnerOrgId).HasColumnName(CoreDataProductClassBasis.Fields.OwnerOrgId);
                this.Property(t => t.VisibilityOrgId).HasColumnName(CoreDataProductClassBasis.Fields.VisibilityOrgId);
                this.Property(t => t.CreateEmployeeId).HasColumnName(CoreDataProductClassBasis.Fields.CreateEmployeeId);
                this.Property(t => t.ChangeEmployeeId).HasColumnName(CoreDataProductClassBasis.Fields.ChangeEmployeeId);
                this.Property(t => t.FromDate).HasColumnName(CoreDataProductClassBasis.Fields.FromDate);
                this.Property(t => t.ToDate).HasColumnName(CoreDataProductClassBasis.Fields.ToDate);
                this.Property(t => t.SortOrder).HasColumnName(CoreDataProductClassBasis.Fields.SortOrder);
                this.Property(t => t.DeleteDate).HasColumnName(CoreDataProductClassBasis.Fields.DeleteDate);
    
                // Relationships
                this.HasRequired(t => t.CoreDataProduct)
                    .WithMany(t => t.CoreDataProductClassBasis)
                    .HasForeignKey(d => d.CoreDataProductId);

                this.HasRequired(t => t.ExamClass)
                    .WithMany(t => t.CoreDataProductClassBasis)
                    .HasForeignKey(d => d.ExamClassId);

                this.HasRequired(t => t.LegalBasis)
                    .WithMany(t => t.CoreDataProductClassBasis)
                    .HasForeignKey(d => d.LegalBasisId);
    
    
            }
        }
}
