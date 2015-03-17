using MetadataLoader.Contracts.Database;
using MetadataLoader.Database;

namespace MasterDataModule.Generation
{
    public class TableContent : BaseMasterDataContent
    {
        public bool IsRelated { get; set; }
        public string RelationFieldName { get; set; }
        public string PrimaryObject { get; set; }
        public string Group { get; set; }
        public string ViewCollections { get; set; }
        public bool IsSystem { get; set; }
        public bool SkipManagerConstructor { get; set; }
        public bool SkipControllerConstructor { get; set; }
        public bool SkipController { get; set; }
        /// <summary>
        /// Add execution of ExtraEntityToModel implemented in partial custom part of controller
        /// </summary>
        public bool ExtraEntityToModel { get; set; }
        /// <summary>
        /// Add execution of ExtraModelToEntity implemented in partial custom part of controller
        /// </summary>
        public bool ExtraModelToEntity { get; set; }

        public bool ShowInMenu { get; set; }

        public string RelationShips { get; set; }
        public string RelationShipsSelectors { get; set; }
        public string RelationShipsDe { get; set; }
        public string RelationShipsEn { get; set; }

        public string TitleFieldName { get; set; }
    }
}