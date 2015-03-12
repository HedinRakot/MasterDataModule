﻿






using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using System.Data.Entity;
using System.Linq;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Database context for for Drl
    /// </summary>
    public partial class DrlEntities: IDrlEntities
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(MessageLocalizationMapping.Instance);
            modelBuilder.Configurations.Add(SysColumnMapping.Instance);
            modelBuilder.Configurations.Add(SysTableMapping.Instance);
            modelBuilder.Configurations.Add(RoleMapping.Instance);
            modelBuilder.Configurations.Add(ReturnReasonMapping.Instance);
            modelBuilder.Configurations.Add(PermissionMapping.Instance);
            modelBuilder.Configurations.Add(ExamPossibleResultMapping.Instance);
            modelBuilder.Configurations.Add(SchoolInfoMapping.Instance);
            modelBuilder.Configurations.Add(ArgeVersionMapping.Instance);
            modelBuilder.Configurations.Add(AuthorityMapping.Instance);
            modelBuilder.Configurations.Add(UserMapping.Instance);
            modelBuilder.Configurations.Add(CommunityMapping.Instance);
            modelBuilder.Configurations.Add(ExamRecognitionTypeMapping.Instance);
            modelBuilder.Configurations.Add(ExamRecognitionTypeExamClassMapping.Instance);
            modelBuilder.Configurations.Add(ExamRoomMapping.Instance);
            modelBuilder.Configurations.Add(ExamStationMapping.Instance);
            modelBuilder.Configurations.Add(ExamStationExamRecognitionTypeMapping.Instance);
            modelBuilder.Configurations.Add(HolidayMapping.Instance);
            modelBuilder.Configurations.Add(ExamClassMapping.Instance);
            modelBuilder.Configurations.Add(HolidayOrdFederalStateMapping.Instance);
            modelBuilder.Configurations.Add(LanguageMapping.Instance);
            modelBuilder.Configurations.Add(ExamClassArgeMapMapping.Instance);
            modelBuilder.Configurations.Add(LegalBasisMapping.Instance);
            modelBuilder.Configurations.Add(ExamClassInclusiveClassMapping.Instance);
            modelBuilder.Configurations.Add(ExamClassMapMapping.Instance);
            modelBuilder.Configurations.Add(ExamClassRequiredClassMapping.Instance);
            modelBuilder.Configurations.Add(ExamClassRestrictedClassMapping.Instance);
            modelBuilder.Configurations.Add(ExamConstraintMapping.Instance);
            modelBuilder.Configurations.Add(MeetingPointMapping.Instance);
            modelBuilder.Configurations.Add(ExamConstraintExamClassMapping.Instance);
            modelBuilder.Configurations.Add(MeetingPointOrganizationalUnitMapping.Instance);
        }

        /// <summary>
        ///     Set of <see cref="MessageLocalization"/> entities from table DATA.DRL_MESSAGE_LOCALIZATION
        /// </summary>
        public IQueryable<MessageLocalization> MessageLocalization{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysColumn"/> entities from table dbo.SYS_COLUMNS
        /// </summary>
        public IQueryable<SysColumn> SysColumn{ get; set; }
        /// <summary>
        ///     Set of <see cref="SysTable"/> entities from table dbo.SYS_TABLES
        /// </summary>
        public IQueryable<SysTable> SysTable{ get; set; }
        /// <summary>
        ///     Set of <see cref="Role"/> entities from table dbo.MASTER_DATA_ROLE
        /// </summary>
        public IQueryable<Role> Role{ get; set; }
        /// <summary>
        ///     Set of <see cref="ReturnReason"/> entities from table DATA.DRL_RETURN_REASON
        /// </summary>
        public IQueryable<ReturnReason> ReturnReason{ get; set; }
        /// <summary>
        ///     Set of <see cref="Permission"/> entities from table dbo.MASTER_DATA_PERMISSION
        /// </summary>
        public IQueryable<Permission> Permission{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamPossibleResult"/> entities from table DATA.DRL_EXAM_POSSIBLE_RESULT
        /// </summary>
        public IQueryable<ExamPossibleResult> ExamPossibleResult{ get; set; }
        /// <summary>
        ///     Set of <see cref="SchoolInfo"/> entities from table DATA.DRL_SCHOOL_INFO
        /// </summary>
        public IQueryable<SchoolInfo> SchoolInfo{ get; set; }
        /// <summary>
        ///     Set of <see cref="ArgeVersion"/> entities from table DATA.DRL_ARGE_VERSION
        /// </summary>
        public IQueryable<ArgeVersion> ArgeVersion{ get; set; }
        /// <summary>
        ///     Set of <see cref="Authority"/> entities from table DATA.DRL_AUTHORITY
        /// </summary>
        public IQueryable<Authority> Authority{ get; set; }
        /// <summary>
        ///     Set of <see cref="User"/> entities from table dbo.MASTER_DATA_USER
        /// </summary>
        public IQueryable<User> User{ get; set; }
        /// <summary>
        ///     Set of <see cref="Community"/> entities from table DATA.DRL_COMMUNITY
        /// </summary>
        public IQueryable<Community> Community{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamRecognitionType"/> entities from table DATA.DRL_EXAM_RECOGNITION_TYPE
        /// </summary>
        public IQueryable<ExamRecognitionType> ExamRecognitionType{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamRecognitionTypeExamClass"/> entities from table DATA.DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP
        /// </summary>
        public IQueryable<ExamRecognitionTypeExamClass> ExamRecognitionTypeExamClass{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamRoom"/> entities from table DATA.DRL_EXAM_ROOM
        /// </summary>
        public IQueryable<ExamRoom> ExamRoom{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamStation"/> entities from table DATA.DRL_EXAM_STATION
        /// </summary>
        public IQueryable<ExamStation> ExamStation{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamStationExamRecognitionType"/> entities from table DATA.DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP
        /// </summary>
        public IQueryable<ExamStationExamRecognitionType> ExamStationExamRecognitionType{ get; set; }
        /// <summary>
        ///     Set of <see cref="Holiday"/> entities from table DATA.DRL_HOLIDAY
        /// </summary>
        public IQueryable<Holiday> Holiday{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamClass"/> entities from table DATA.DRL_EXAM_CLASS
        /// </summary>
        public IQueryable<ExamClass> ExamClass{ get; set; }
        /// <summary>
        ///     Set of <see cref="HolidayOrdFederalState"/> entities from table DATA.DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP
        /// </summary>
        public IQueryable<HolidayOrdFederalState> HolidayOrdFederalState{ get; set; }
        /// <summary>
        ///     Set of <see cref="Language"/> entities from table DATA.DRL_LANGUAGE
        /// </summary>
        public IQueryable<Language> Language{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamClassArgeMap"/> entities from table DATA.DRL_EXAM_CLASS_ARGE_MAP
        /// </summary>
        public IQueryable<ExamClassArgeMap> ExamClassArgeMap{ get; set; }
        /// <summary>
        ///     Set of <see cref="LegalBasis"/> entities from table DATA.DRL_LEGAL_BASIS
        /// </summary>
        public IQueryable<LegalBasis> LegalBasis{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamClassInclusiveClass"/> entities from table DATA.DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP
        /// </summary>
        public IQueryable<ExamClassInclusiveClass> ExamClassInclusiveClass{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamClassMap"/> entities from table DATA.DRL_EXAM_CLASS_MAP
        /// </summary>
        public IQueryable<ExamClassMap> ExamClassMap{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamClassRequiredClass"/> entities from table DATA.DRL_EXAM_CLASS_REQUIRED_CLASS_RSP
        /// </summary>
        public IQueryable<ExamClassRequiredClass> ExamClassRequiredClass{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamClassRestrictedClass"/> entities from table DATA.DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP
        /// </summary>
        public IQueryable<ExamClassRestrictedClass> ExamClassRestrictedClass{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamConstraint"/> entities from table DATA.DRL_EXAM_CONSTRAINT
        /// </summary>
        public IQueryable<ExamConstraint> ExamConstraint{ get; set; }
        /// <summary>
        ///     Set of <see cref="MeetingPoint"/> entities from table DATA.DRL_MEETING_POINT
        /// </summary>
        public IQueryable<MeetingPoint> MeetingPoint{ get; set; }
        /// <summary>
        ///     Set of <see cref="ExamConstraintExamClass"/> entities from table DATA.DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP
        /// </summary>
        public IQueryable<ExamConstraintExamClass> ExamConstraintExamClass{ get; set; }
        /// <summary>
        ///     Set of <see cref="MeetingPointOrganizationalUnit"/> entities from table DATA.DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP
        /// </summary>
        public IQueryable<MeetingPointOrganizationalUnit> MeetingPointOrganizationalUnit{ get; set; }
    }
}