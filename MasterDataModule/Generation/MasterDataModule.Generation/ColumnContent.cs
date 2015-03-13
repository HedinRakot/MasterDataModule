using MetadataLoader.Contracts.Database;
using MetadataLoader.Database;

namespace MasterDataModule.Generation
{
    public class ColumnContent : BaseMasterDataContent
    {
        public bool InModel { get; set; }
        public bool ShowInGrid { get; set; }
        public bool IsModelRequired { get; set; }
        
        public string JsModelType { get; set; }
        public bool JsSkipStandardValidation { get; set; }
        public string JsExtraValidation { get; set; }
    }
}