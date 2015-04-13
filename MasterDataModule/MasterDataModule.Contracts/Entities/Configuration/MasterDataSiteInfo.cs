using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Web-Site Einstellungen  EN: Master data sites
    /// </summary>
    public partial class MasterDataSiteInfo: IHasId<int>
        ,IHasTitle
        ,IIntervalFields
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_SITE_INFO";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataSiteInfo.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="MasterDataSiteInfo.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'TIMEOUT_CHECKING' for property <see cref="MasterDataSiteInfo.TimeoutChecking"/>
            /// </summary>
            public static readonly string TimeoutChecking = "TIMEOUT_CHECKING";
            /// <summary>
            /// Column name 'SITE_PATH' for property <see cref="MasterDataSiteInfo.SitePath"/>
            /// </summary>
            public static readonly string SitePath = "SITE_PATH";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataSiteInfo.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataSiteInfo.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataSiteInfo.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="MasterDataSiteInfo.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="MasterDataSiteInfo.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Site-Name  EN: Site name
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        ///     DE: Timeout  EN: Timeout
        /// </summary>
        public int TimeoutChecking{ get; set; }
        /// <summary>
        ///     DE: Url  EN: Url
        /// </summary>
        public string SitePath{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        /// <summary>
        ///     DE:Von Datum  EN:  Date from
        /// </summary>
        public DateTime FromDate{ get; set; }
        /// <summary>
        ///     DE:Bis Datum  EN:  Date to
        /// </summary>
        public DateTime ToDate{ get; set; }
        public virtual ICollection<MasterDataSiteCheckResults> MasterDataSiteCheckResults{ get; set; }
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
        string IHasTitle.EntityTitle
        {
            get { return Name; }
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
        public MasterDataSiteInfo ShallowCopy()
        {
            return new MasterDataSiteInfo {
                       Name = Name,
                       TimeoutChecking = TimeoutChecking,
                       SitePath = SitePath,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
        	           };
        }
    }
}
