






using MasterDataModule.Contracts.Entities;
using System.Linq;

namespace MasterDataModule.Contracts
{
    /// <summary>
    ///     Interface for Drl context
    /// </summary>
    public partial interface IDrlEntities
    {
        /// <summary>
        ///     Set of <see cref="MessageLocalization"/> entities from table DATA.DRL_MESSAGE_LOCALIZATION
        /// </summary>
        IQueryable<MessageLocalization> MessageLocalization{get;}
        /// <summary>
        ///     Set of <see cref="SysColumn"/> entities from table dbo.SYS_COLUMNS
        /// </summary>
        IQueryable<SysColumn> SysColumn{get;}
        /// <summary>
        ///     Set of <see cref="SysTable"/> entities from table dbo.SYS_TABLES
        /// </summary>
        IQueryable<SysTable> SysTable{get;}
        /// <summary>
        ///     Set of <see cref="Role"/> entities from table dbo.MASTER_DATA_ROLE
        /// </summary>
        IQueryable<Role> Role{get;}
        /// <summary>
        ///     Set of <see cref="ReturnReason"/> entities from table DATA.DRL_RETURN_REASON
        /// </summary>
        IQueryable<ReturnReason> ReturnReason{get;}
        /// <summary>
        ///     Set of <see cref="Permission"/> entities from table dbo.MASTER_DATA_PERMISSION
        /// </summary>
        IQueryable<Permission> Permission{get;}
        /// <summary>
        ///     Set of <see cref="ExamPossibleResult"/> entities from table DATA.DRL_EXAM_POSSIBLE_RESULT
        /// </summary>
        IQueryable<ExamPossibleResult> ExamPossibleResult{get;}
        /// <summary>
        ///     Set of <see cref="SchoolInfo"/> entities from table DATA.DRL_SCHOOL_INFO
        /// </summary>
        IQueryable<SchoolInfo> SchoolInfo{get;}
        /// <summary>
        ///     Set of <see cref="ArgeVersion"/> entities from table DATA.DRL_ARGE_VERSION
        /// </summary>
        IQueryable<ArgeVersion> ArgeVersion{get;}
        /// <summary>
        ///     Set of <see cref="Authority"/> entities from table DATA.DRL_AUTHORITY
        /// </summary>
        IQueryable<Authority> Authority{get;}
        /// <summary>
        ///     Set of <see cref="User"/> entities from table dbo.MASTER_DATA_USER
        /// </summary>
        IQueryable<User> User{get;}
        /// <summary>
        ///     Set of <see cref="Community"/> entities from table DATA.DRL_COMMUNITY
        /// </summary>
        IQueryable<Community> Community{get;}
        /// <summary>
        ///     Set of <see cref="ExamRecognitionType"/> entities from table DATA.DRL_EXAM_RECOGNITION_TYPE
        /// </summary>
        IQueryable<ExamRecognitionType> ExamRecognitionType{get;}
        /// <summary>
        ///     Set of <see cref="ExamRecognitionTypeExamClass"/> entities from table DATA.DRL_EXAM_RECOGNITION_TYPE_EXAM_CLASS_RSP
        /// </summary>
        IQueryable<ExamRecognitionTypeExamClass> ExamRecognitionTypeExamClass{get;}
        /// <summary>
        ///     Set of <see cref="ExamRoom"/> entities from table DATA.DRL_EXAM_ROOM
        /// </summary>
        IQueryable<ExamRoom> ExamRoom{get;}
        /// <summary>
        ///     Set of <see cref="ExamStation"/> entities from table DATA.DRL_EXAM_STATION
        /// </summary>
        IQueryable<ExamStation> ExamStation{get;}
        /// <summary>
        ///     Set of <see cref="ExamStationExamRecognitionType"/> entities from table DATA.DRL_EXAM_STATION_EXAM_RECOGNITION_TYPE_RSP
        /// </summary>
        IQueryable<ExamStationExamRecognitionType> ExamStationExamRecognitionType{get;}
        /// <summary>
        ///     Set of <see cref="Holiday"/> entities from table DATA.DRL_HOLIDAY
        /// </summary>
        IQueryable<Holiday> Holiday{get;}
        /// <summary>
        ///     Set of <see cref="ExamClass"/> entities from table DATA.DRL_EXAM_CLASS
        /// </summary>
        IQueryable<ExamClass> ExamClass{get;}
        /// <summary>
        ///     Set of <see cref="HolidayOrdFederalState"/> entities from table DATA.DRL_HOLIDAY_ORD_FEDERAL_STATE_RSP
        /// </summary>
        IQueryable<HolidayOrdFederalState> HolidayOrdFederalState{get;}
        /// <summary>
        ///     Set of <see cref="Language"/> entities from table DATA.DRL_LANGUAGE
        /// </summary>
        IQueryable<Language> Language{get;}
        /// <summary>
        ///     Set of <see cref="ExamClassArgeMap"/> entities from table DATA.DRL_EXAM_CLASS_ARGE_MAP
        /// </summary>
        IQueryable<ExamClassArgeMap> ExamClassArgeMap{get;}
        /// <summary>
        ///     Set of <see cref="LegalBasis"/> entities from table DATA.DRL_LEGAL_BASIS
        /// </summary>
        IQueryable<LegalBasis> LegalBasis{get;}
        /// <summary>
        ///     Set of <see cref="ExamClassInclusiveClass"/> entities from table DATA.DRL_EXAM_CLASS_INCLUSIVE_CLASS_RSP
        /// </summary>
        IQueryable<ExamClassInclusiveClass> ExamClassInclusiveClass{get;}
        /// <summary>
        ///     Set of <see cref="ExamClassMap"/> entities from table DATA.DRL_EXAM_CLASS_MAP
        /// </summary>
        IQueryable<ExamClassMap> ExamClassMap{get;}
        /// <summary>
        ///     Set of <see cref="ExamClassRequiredClass"/> entities from table DATA.DRL_EXAM_CLASS_REQUIRED_CLASS_RSP
        /// </summary>
        IQueryable<ExamClassRequiredClass> ExamClassRequiredClass{get;}
        /// <summary>
        ///     Set of <see cref="ExamClassRestrictedClass"/> entities from table DATA.DRL_EXAM_CLASS_RESTRICTED_CLASS_RSP
        /// </summary>
        IQueryable<ExamClassRestrictedClass> ExamClassRestrictedClass{get;}
        /// <summary>
        ///     Set of <see cref="ExamConstraint"/> entities from table DATA.DRL_EXAM_CONSTRAINT
        /// </summary>
        IQueryable<ExamConstraint> ExamConstraint{get;}
        /// <summary>
        ///     Set of <see cref="MeetingPoint"/> entities from table DATA.DRL_MEETING_POINT
        /// </summary>
        IQueryable<MeetingPoint> MeetingPoint{get;}
        /// <summary>
        ///     Set of <see cref="ExamConstraintExamClass"/> entities from table DATA.DRL_EXAM_CONSTRAINT_EXAM_CLASS_RSP
        /// </summary>
        IQueryable<ExamConstraintExamClass> ExamConstraintExamClass{get;}
        /// <summary>
        ///     Set of <see cref="MeetingPointOrganizationalUnit"/> entities from table DATA.DRL_MEETING_POINT_ORGANIZATIONAL_UNIT_RSP
        /// </summary>
        IQueryable<MeetingPointOrganizationalUnit> MeetingPointOrganizationalUnit{get;}
    }
}
