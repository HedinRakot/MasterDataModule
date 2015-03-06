using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData
{
    /// <summary>
    /// 
    /// </summary>
    public class SysColumn : IHasId<int>, IHasTitle, IRemovable
	{
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "SYS_COLUMNS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// 
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// 
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// 
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// 
            /// </summary>
            public static readonly string ReadOnly = "READ_ONLY";
            /// <summary>
            /// 
            /// </summary>
            public static readonly string SysTableId = "SYS_TABLE_ID";
            /// <summary>
            /// 
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// 
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public SysColumn()
		{

		}

        /// <summary>
        /// 
        /// </summary>
		public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int SysTableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual SysTable SysTable { get; set; }
		
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// ANLAGEDATUM (INSERT-DATUM)  
        /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
        /// DELETE-DATUM
        /// </summary>
        public System.DateTime? DeleteDate { get; set; }
        
        public string EntityTitle { get { return Name; } }
	}
}
