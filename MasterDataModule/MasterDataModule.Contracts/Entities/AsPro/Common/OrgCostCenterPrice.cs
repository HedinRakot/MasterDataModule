using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     DE: Zuordnung Preise zu Kostenstelle  EN: Cost center price
    /// </summary>
    public partial class OrgCostCenterPrice: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.ORG_COST_CENTER_PRICE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'INS_CORE_DATA_PRODUCT_ID' for property <see cref="OrgCostCenterPrice.InsCoreDataProductId"/>
            /// </summary>
            public static readonly string InsCoreDataProductId = "INS_CORE_DATA_PRODUCT_ID";
            /// <summary>
            /// Column name 'SALES_OFFICE' for property <see cref="OrgCostCenterPrice.SalesOffice"/>
            /// </summary>
            public static readonly string SalesOffice = "SALES_OFFICE";
            /// <summary>
            /// Column name 'SALES_GROUP' for property <see cref="OrgCostCenterPrice.SalesGroup"/>
            /// </summary>
            public static readonly string SalesGroup = "SALES_GROUP";
            /// <summary>
            /// Column name 'MIN_PRICE' for property <see cref="OrgCostCenterPrice.MinPrice"/>
            /// </summary>
            public static readonly string MinPrice = "MIN_PRICE";
            /// <summary>
            /// Column name 'MAX_PRICE' for property <see cref="OrgCostCenterPrice.MaxPrice"/>
            /// </summary>
            public static readonly string MaxPrice = "MAX_PRICE";
            /// <summary>
            /// Column name 'STANDART_PRICE' for property <see cref="OrgCostCenterPrice.StandartPrice"/>
            /// </summary>
            public static readonly string StandartPrice = "STANDART_PRICE";
            /// <summary>
            /// Column name 'QUANTITY' for property <see cref="OrgCostCenterPrice.Quantity"/>
            /// </summary>
            public static readonly string Quantity = "QUANTITY";
            /// <summary>
            /// Column name 'UNIT_OF_MEASURE' for property <see cref="OrgCostCenterPrice.UnitOfMeasure"/>
            /// </summary>
            public static readonly string UnitOfMeasure = "UNIT_OF_MEASURE";
            /// <summary>
            /// Column name 'SYS_CURRENCY_ID' for property <see cref="OrgCostCenterPrice.SysCurrencyId"/>
            /// </summary>
            public static readonly string SysCurrencyId = "SYS_CURRENCY_ID";
            /// <summary>
            /// Column name 'CHANGE_ABILITY_TYPE' for property <see cref="OrgCostCenterPrice.ChangeAbilityType"/>
            /// </summary>
            public static readonly string ChangeAbilityType = "CHANGE_ABILITY_TYPE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="OrgCostCenterPrice.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="OrgCostCenterPrice.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="OrgCostCenterPrice.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="OrgCostCenterPrice.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="OrgCostCenterPrice.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="OrgCostCenterPrice.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="OrgCostCenterPrice.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="OrgCostCenterPrice.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="OrgCostCenterPrice.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="OrgCostCenterPrice.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'ORG_ACCOUNTING_AREA_ID' for property <see cref="OrgCostCenterPrice.OrgAccountingAreaId"/>
            /// </summary>
            public static readonly string OrgAccountingAreaId = "ORG_ACCOUNTING_AREA_ID";
            /// <summary>
            /// Column name 'ID' for property <see cref="OrgCostCenterPrice.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
          
        }
        #endregion
        /// <summary>
        ///     DE: Produkt   EN: Product
        /// </summary>
        public int InsCoreDataProductId{ get; set; }
        /// <summary>
        ///     DE: Verkaufsbüro (ersten 4 Stellen der Kostenstelle)  EN: Sales office
        /// </summary>
        public string SalesOffice{ get; set; }
        /// <summary>
        ///     DE: Verkäufergruppe (letzten 3 Stellen der Kostenstelle), dieser Wert kann auch leer sein, dann gilt der Preis für das ganze Verkaufsbüro (Niederlassung)  EN: Sales group
        /// </summary>
        public string SalesGroup{ get; set; }
        /// <summary>
        ///     DE: Minimaler Preis  EN: Min price
        /// </summary>
        public decimal? MinPrice{ get; set; }
        /// <summary>
        ///     DE: Maximaler Preis  EN: Max price
        /// </summary>
        public decimal? MaxPrice{ get; set; }
        /// <summary>
        ///     DE: Standartpreis  EN: Standart prict
        /// </summary>
        public decimal? StandartPrice{ get; set; }
        /// <summary>
        ///     DE: verkaufte Menge   EN: Quantity
        /// </summary>
        public int Quantity{ get; set; }
        /// <summary>
        ///     DE: Mengeneinheit (Kombobox) mit folgenden Werten „ST“ = Stück, „H“ = Stunde  EN: Unit of measure
        /// </summary>
        public string UnitOfMeasure{ get; set; }
        /// <summary>
        ///     DE: Währungskennzeichen  EN: Currency
        /// </summary>
        public int? SysCurrencyId{ get; set; }
        /// <summary>
        ///     DE: Preisänderung (Kombobox mit folgenden Werten 0= “nicht änderbar“, 1= “änderbar mit Begründung“, 2= “änderbar ohne Begründung“)  EN: Change ability type
        /// </summary>
        public int? ChangeAbilityType{ get; set; }
        /// <summary>
        ///     DE: Von Datum  EN: From date
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     DE: Bis Datum  EN: To date
        /// </summary>
        public DateTime ToDate{ get; set; }
        public DateTime? CreateDate{ get; set; }
        public DateTime? ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public int? OwnerOrgId{ get; set; }
        public int? VisibilityOrgId{ get; set; }
        public int? CreateEmployeeId{ get; set; }
        public int? ChangeEmployeeId{ get; set; }
        public string Source{ get; set; }
        public int? OrgAccountingAreaId{ get; set; }
        public int Id{ get; set; }
        DateTime? IIntervalFields.FromDate
        {
            get { return FromDate; }
            set { if(value.HasValue)FromDate = value.Value; else throw new ArgumentNullException("value"); }
        }
        DateTime? IIntervalFields.ToDate
        {
            get { return ToDate; }
            set { if(value.HasValue)ToDate = value.Value; else throw new ArgumentNullException("value"); }
        }
        DateTime ISystemFields.CreateDate
        {
            get { if(CreateDate.HasValue) return CreateDate.Value; else return DateTime.Now; }
            set { CreateDate = value; }
        }
        DateTime ISystemFields.ChangeDate
        {
            get { if(ChangeDate.HasValue) return ChangeDate.Value; else return CreateDate ?? DateTime.Now; }
            set { ChangeDate = value; }
        }
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public OrgCostCenterPrice ShallowCopy()
        {
            return new OrgCostCenterPrice {
                       InsCoreDataProductId = InsCoreDataProductId,
                       SalesOffice = SalesOffice,
                       SalesGroup = SalesGroup,
                       MinPrice = MinPrice,
                       MaxPrice = MaxPrice,
                       StandartPrice = StandartPrice,
                       Quantity = Quantity,
                       UnitOfMeasure = UnitOfMeasure,
                       SysCurrencyId = SysCurrencyId,
                       ChangeAbilityType = ChangeAbilityType,
                       FromDate = FromDate,
                       ToDate = ToDate,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
                       OwnerOrgId = OwnerOrgId,
                       VisibilityOrgId = VisibilityOrgId,
                       CreateEmployeeId = CreateEmployeeId,
                       ChangeEmployeeId = ChangeEmployeeId,
                       Source = Source,
                       OrgAccountingAreaId = OrgAccountingAreaId,
        	           };
        }
    }
}
