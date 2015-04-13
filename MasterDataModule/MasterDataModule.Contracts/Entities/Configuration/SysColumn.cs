using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Stammdaten Spalte  EN: Master data column
    /// </summary>
    public partial class SysColumn: IHasId<int>
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.SYS_COLUMNS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="SysColumn.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'SYS_TABLE_ID' for property <see cref="SysColumn.SysTableId"/>
            /// </summary>
            public static readonly string SysTableId = "SYS_TABLE_ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="SysColumn.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="SysColumn.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="SysColumn.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="SysColumn.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'READ_ONLY' for property <see cref="SysColumn.ReadOnly"/>
            /// </summary>
            public static readonly string ReadOnly = "READ_ONLY";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="SysColumn.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="SysColumn.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="SysColumn.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Tabelle  EN: Table
        /// </summary>
        public int SysTableId{ get; set; }
        /// <summary>
        ///     DE: Name  EN: Name
        /// </summary>
        public string Name{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        /// <summary>
        ///     DE: Beschreibung  EN: Description
        /// </summary>
        public string Description{ get; set; }
        /// <summary>
        ///     DE: Nicht editierbar  EN: Readonly
        /// </summary>
        public bool ReadOnly{ get; set; }
        public DateTime ChangeDate{ get; set; }
        /// <summary>
        ///     DE:Von Datum  EN:  Date from
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     DE:Bis Datum  EN:  Date to
        /// </summary>
        public DateTime ToDate{ get; set; }
        public virtual SysTable SysTable{ get; set; }
        public bool HasSysTable
        {
            get { return !ReferenceEquals(SysTable, null); }
        }
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
            get { return CreateDate; }
            set { CreateDate = value; }
        }
        DateTime ISystemFields.ChangeDate
        {
            get { return ChangeDate; }
            set { ChangeDate = value; }
        }
                
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public SysColumn ShallowCopy()
        {
            return new SysColumn {
                       SysTableId = SysTableId,
                       Name = Name,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       Description = Description,
                       ReadOnly = ReadOnly,
                       ChangeDate = ChangeDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
        	           };
        }
    }
}
