using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     CollectionTypesModel class
    /// </summary>
    public partial class CollectionTypesModel
    {
        public bool ReturnReason { get; set;}
        public bool SchoolInfo { get; set;}
        public bool ExamRecognitionType { get; set;}
        public bool ExamClass { get; set;}
        public bool LegalBasis { get; set;}
    }
}
