using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class SiteInfosWithLastResult: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.SITE_INFOS_WITH_LAST_RESULT";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="SiteInfosWithLastResult.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="SiteInfosWithLastResult.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="SiteInfosWithLastResult.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="SiteInfosWithLastResult.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="SiteInfosWithLastResult.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'LAST_RESULT' for property <see cref="SiteInfosWithLastResult.LastResult"/>
            /// </summary>
            public static readonly string LastResult = "LAST_RESULT";
          
        }
        #endregion
        public int Id{ get; set; }
        public string Name{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public int? LastResult{ get; set; }
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
        public SiteInfosWithLastResult ShallowCopy()
        {
            return new SiteInfosWithLastResult {
                       Id = Id,
                       Name = Name,
                       DeleteDate = DeleteDate,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       LastResult = LastResult,
        	           };
        }
    }
}
