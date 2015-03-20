using MasterDataModule.Contracts.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Mappping table DATA.DRL_COMMUNITY_PARTICIPANT to entity <see cref="CommunityParticipant"/>
    /// </summary>
    internal sealed class CommunityParticipantMapping: EntityTypeConfiguration<CommunityParticipant>
    {
        
        public static readonly CommunityParticipantMapping Instance = new CommunityParticipantMapping();
        
        /// <summary>
        ///     Initializes a new instance of the <see cref="CommunityParticipantMapping" /> class.
        /// </summary>
        private CommunityParticipantMapping()
        {

            ToTable("DRL_COMMUNITY_PARTICIPANT", "DATA");
            // Primary Key
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Id)
                .HasColumnName(CommunityParticipant.Fields.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(t => t.DriverSchoolIdParticipant)
                .HasColumnName(CommunityParticipant.Fields.DriverSchoolIdParticipant)
                .IsRequired();

            Property(t => t.CreateDate)
                .HasColumnName(CommunityParticipant.Fields.CreateDate)
                .IsRequired();

            Property(t => t.ChangeDate)
                .HasColumnName(CommunityParticipant.Fields.ChangeDate)
                .IsRequired();

            Property(t => t.DeleteDate)
                .HasColumnName(CommunityParticipant.Fields.DeleteDate);

            Property(t => t.OwnerOrgId)
                .HasColumnName(CommunityParticipant.Fields.OwnerOrgId);

            Property(t => t.VisibilityOrgId)
                .HasColumnName(CommunityParticipant.Fields.VisibilityOrgId);

            Property(t => t.CreateEmployeeId)
                .HasColumnName(CommunityParticipant.Fields.CreateEmployeeId);

            Property(t => t.ChangeEmployeeId)
                .HasColumnName(CommunityParticipant.Fields.ChangeEmployeeId);

            Property(t => t.Source)
                .HasColumnName(CommunityParticipant.Fields.Source)
                .HasMaxLength(10);

            Property(t => t.FromDate)
                .HasColumnName(CommunityParticipant.Fields.FromDate)
                .IsRequired();

            Property(t => t.ToDate)
                .HasColumnName(CommunityParticipant.Fields.ToDate)
                .IsRequired();

            Property(t => t.DriverSchoolIdLead)
                .HasColumnName(CommunityParticipant.Fields.DriverSchoolIdLead)
                .IsRequired();


            //Relationships
            HasRequired(c => c.DriverSchool)
                .WithMany(d => d.CommunityParticipants)
                .HasForeignKey(t => t.DriverSchoolIdParticipant);
            HasRequired(c => c.DriverSchool2)
                .WithMany(d => d.CommunityParticipants2)
                .HasForeignKey(t => t.DriverSchoolIdLead);
        }
    }
}
