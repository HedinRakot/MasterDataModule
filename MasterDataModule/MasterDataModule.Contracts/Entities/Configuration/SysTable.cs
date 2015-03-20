using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     Database tables
    /// </summary>
    public partial class SysTable: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.SYS_TABLES";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="SysTable.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="SysTable.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="SysTable.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="SysTable.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="SysTable.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'EDIT_MODE' for property <see cref="SysTable.EditMode"/>
            /// </summary>
            public static readonly string EditMode = "EDIT_MODE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="SysTable.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public string Name{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public string Description{ get; set; }
        public int EditMode{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public virtual ICollection<SysColumn> SysColumns{ get; set; }
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
        public SysTable ShallowCopy()
        {
            return new SysTable {
                       Name = Name,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       Description = Description,
                       EditMode = EditMode,
                       ChangeDate = ChangeDate,
        	           };
        }
    }
}
