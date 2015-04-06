// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using MonitoringAgent.Data.Interfaces.Entities;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace MonitoringAgent.Common.Data
{
    // GET_WCF_SERVICES_STATUS
    internal partial class GetWcfServicesStatusConfiguration : EntityTypeConfiguration<GetWcfServicesStatus>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public GetWcfServicesStatusConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GET_WCF_SERVICES_STATUS");
            HasKey(x => new { x.Id, x.Name, x.WsdlPath, x.CreateDate, x.ChangeDate });

            Property(x => x.Id).HasColumnName("ID").IsRequired();
            Property(x => x.CheckStatus).HasColumnName("CHECK_STATUS").IsOptional();
            Property(x => x.CheckDate).HasColumnName("CHECK_DATE").IsOptional();
            Property(x => x.Message).HasColumnName("MESSAGE").IsOptional();
            Property(x => x.Attempt).HasColumnName("ATTEMPT").IsOptional();
            Property(x => x.Name).HasColumnName("NAME").IsRequired();
            Property(x => x.WsdlPath).HasColumnName("WSDL_PATH").IsRequired();
            Property(x => x.DeleteDate).HasColumnName("DELETE_DATE").IsOptional();
            Property(x => x.CreateDate).HasColumnName("CREATE_DATE").IsRequired();
            Property(x => x.ChangeDate).HasColumnName("CHANGE_DATE").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
