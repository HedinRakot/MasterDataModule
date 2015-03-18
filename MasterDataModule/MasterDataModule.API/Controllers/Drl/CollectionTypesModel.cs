using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     CollectionTypesModel class
    /// </summary>
    public partial class CollectionTypesModel
    {
        public bool MessageLocalization { get; set;}
        public bool SysColumn { get; set;}
        public bool SysTable { get; set;}
        public bool ReturnReason { get; set;}
        public bool ExamPossibleResult { get; set;}
        public bool SchoolInfo { get; set;}
        public bool ArgeVersion { get; set;}
        public bool Authority { get; set;}
        public bool Community { get; set;}
        public bool ExamRecognitionType { get; set;}
        public bool ExamRecognitionTypeExamClass { get; set;}
        public bool ExamRoom { get; set;}
        public bool ExamStation { get; set;}
        public bool ExamStationExamRecognitionType { get; set;}
        public bool Holiday { get; set;}
        public bool ExamClass { get; set;}
        public bool HolidayOrdFederalState { get; set;}
        public bool Language { get; set;}
        public bool ExamClassArgeMap { get; set;}
        public bool LegalBasis { get; set;}
        public bool ExamClassInclusiveClass { get; set;}
        public bool ExamClassMap { get; set;}
        public bool ExamClassRequiredClass { get; set;}
        public bool ExamClassRestrictedClass { get; set;}
        public bool ExamConstraint { get; set;}
        public bool MeetingPoint { get; set;}
        public bool ExamConstraintExamClass { get; set;}
        public bool MeetingPointOrganizationalUnit { get; set;}
    }
}
