using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.Entities.MasterDataModule.Common;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data.Common
{
    public class OrgAccountingAreaMapping : EntityTypeConfiguration<OrgAccountingArea>
    {
        public static readonly OrgAccountingAreaMapping Instance = new OrgAccountingAreaMapping();

        /// <summary>
        /// Instance constructor
        /// </summary>
        private OrgAccountingAreaMapping()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.AccountingArea)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ORG_ACCOUNTING_AREA", "dbo");
            this.Property(t => t.Id).HasColumnName(OrgAccountingArea.Fields.Id);
            this.Property(t => t.AccountingArea).HasColumnName(OrgAccountingArea.Fields.AccountingArea);
            this.Property(t => t.DeleteDate).HasColumnName(OrgAccountingArea.Fields.DeleteDate);
        }
    }
}
