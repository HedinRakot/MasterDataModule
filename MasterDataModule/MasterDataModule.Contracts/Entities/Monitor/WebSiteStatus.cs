
using System;

namespace MasterDataModule.Contracts.Entities.Monitor
{
    public partial class WebSiteStatus : IHasId<int>, IRemovable, ISystemFields
    {
        /// <summary>
        /// Table name
        /// 
        /// </summary>
        public static readonly string EntityTableName = "dbo.GET_SITES_STATUS";

        #region Fields

        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID'  </summary>
            public static readonly string Id = "ID";

            /// <summary>
            /// Column name 'CHECK_STATUS'  </summary>
            public static readonly string CheckStatus = "CHECK_STATUS";

            /// <summary>
            /// Column name 'CHECK_DATE' 
            /// </summary>
            public static readonly string CheckDate = "CHECK_DATE";
            /// <summary>
            /// Column name 'MESSAGE' 
            /// </summary>
            public static readonly string Message = "MESSAGE";

            /// <summary>
            /// Column name 'ATTEMPT' 
            /// </summary>
            public static readonly string Attempt = "ATTEMPT";

            /// <summary>
            /// Column name 'NAME' 
            /// </summary>
            public static readonly string Name = "NAME";

            /// <summary>
            /// Column name 'SITE_PATH' 
            /// </summary>
            public static readonly string SitePath = "SITE_PATH";

            public static readonly string DeleteDate = "DELETE_DATE";
            public static readonly string CreateDate = "CREATE_DATE";
            public static readonly string ChangeDate = "CHANGE_DATE";


           
        }

        #endregion

        public int Id { get; set; }

        public int? CheckStatus { get; set; }
        public DateTime? CheckDate { get; set; }
        public string Message { get; set; }
        public int? Attempt { get; set; }
        public string Name { get; set; }
        public string SitePath { get; set; }
        public DateTime? DeleteDate { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }

        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public WebSiteStatus ShallowCopy()
        {
            return new WebSiteStatus
            {
                Name = Name,
                CheckDate = CheckDate,
                CheckStatus = CheckStatus,
                Attempt = Attempt,
                Message = Message,
                SitePath = SitePath
            };
        }

       
    }
}

