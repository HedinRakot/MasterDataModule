using System.Collections.Generic;
using System.Linq;
using MetadataLoader.Contracts.CSharp;
using MetadataLoader.EntityFramework;
using MetadataLoader.MSSQL.Contracts.Database;
using MetadataLoader.MSSQL.EntityFramework;

namespace MasterDataModule.Generation
{
    public sealed class EntitiesManager
    {
        public static EntitiesManager Create()
        {
            return new EntitiesManager();
        }
        #region	Private fields
        private readonly IEntityLoader<MSSQLTable<TableContent, ColumnContent>> _entityLoader;
        #endregion
        #region Constructor
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public EntitiesManager()
        {
            _entityLoader = MSSQLManager<TableContent, ColumnContent>.Instance.GetEntityLoader(
                new EntityExtractor(),
                new EntityPropertyExtractor(),
                new EntityRelationshipExtractor());
        }
        #endregion
        #region	Public methods
        public List<EntityInfo> Load(IEnumerable<MSSQLTable<TableContent, ColumnContent>> tables)
        {
            var entities = _entityLoader.Load(tables);

            //TODO: Remove it after implement interfaces in entities
            var iremovable = TypeUsageInfo.CreateInterface("IRemovable", "MasterDataModule.Contracts");
            var ihasid = TypeUsageInfo.CreateInterface("IHasId", "MasterDataModule.Contracts", new[] {typeof (int).ToUsageInfo()});
            var iintervalfields = TypeUsageInfo.CreateInterface("IIntervalFields", "MasterDataModule.Contracts");
            var ihastitle = TypeUsageInfo.CreateInterface("IHasTitle", "MasterDataModule.Contracts");
   
            foreach (var entity in entities)
            {
                entity.InheritsFrom(iremovable);
                entity.InheritsFrom(ihasid);
                #region IntervalFields
                {
                    var fromDate = entity.SimpleProperties.FirstOrDefault(p => p.Name == "FromDate");
                    var toDate = entity.SimpleProperties.FirstOrDefault(p => p.Name == "ToDate");
                    if (fromDate != null && toDate != null)
                    {
                        entity.InheritsFrom(iintervalfields);

                        AddExplicitProperty(fromDate, iintervalfields, entity);
                        AddExplicitProperty(toDate, iintervalfields, entity);
                    }
                }
                #endregion

                var tableContent = tables.
                    First(table => table.Name == entity.TableName && table.Schema == entity.TableSchemaName).Content;

                if (!string.IsNullOrEmpty(tableContent.TitleFieldName))
                {
                    entity.InheritsFrom(ihastitle);
                    AddHasTitleProperty(ihastitle, entity, tableContent);
                }
            }
            return entities;
        }
        internal static void AddExplicitProperty(PropertyInfo property, TypeUsageInfo iintervalfields, EntityInfo entity)
        {
            if (property.Type.IsNullable)
            {
                return;
            }
            var prop = new PropertyInfo(property.Name, TypeUsageInfo.CreateNullable(property.Type),
                new PropertyInvokerInfo(string.Format("return {0};", property.Name)),
                new PropertyInvokerInfo(string.Format("if(value.HasValue){0} = value.Value; else throw new ArgumentNullException(\"value\");", property.Name)));
            prop.ExplicitInterface = iintervalfields;
            entity.AddProperty(prop);
        }

        internal static void AddHasTitleProperty(TypeUsageInfo ihastitle, EntityInfo entity, TableContent tableContent)
        {
            var prop = new PropertyInfo("EntityTitle", new FieldInfo("EntityTitle", (typeof(string)).ToUsageInfo()),
                new PropertyInvokerInfo(string.Format("return {0};", tableContent.TitleFieldName)),
                null);
            prop.ExplicitInterface = ihastitle;
            entity.AddProperty(prop);
        }
        #endregion
    }
}