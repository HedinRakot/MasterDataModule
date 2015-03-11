using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     Database tables columns
    /// </summary>
    public partial class SysColumn: IHasId<int>
        ,IRemovable
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
          
        }
        #endregion
        public int Id{ get; set; }
        public int SysTableId{ get; set; }
        public string Name{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public string Description{ get; set; }
        public bool ReadOnly{ get; set; }
        public virtual SysTable SysTable{ get; set; }
        public bool HasSysTable
        {
            get { return !ReferenceEquals(SysTable, null); }
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
        	           };
        }
    }
}
