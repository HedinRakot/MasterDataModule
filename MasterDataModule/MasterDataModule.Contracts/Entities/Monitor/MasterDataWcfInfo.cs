
using System;

namespace MasterDataModule.Contracts.Entities.Monitor
{
    public partial class MasterDataWcfInfo : IHasId<int>, IRemovable, ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_WCF_INFO";

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
            /// Column name 'TIMEOUT_CHECKING' 
            /// </summary>
            public static readonly string TimeoutChecking = "TIMEOUT_CHECKING";

            /// <summary>
            /// Column name 'NAME' 
            /// </summary>
            public static readonly string Name = "NAME";

            /// <summary>
            /// Column name 'WSDL_PATH' 
            /// </summary>
            public static readonly string WsdlPath = "WSDL_PATH";

            public static readonly string DeleteDate = "DELETE_DATE";
            public static readonly string CreateDate = "CREATE_DATE";
            public static readonly string ChangeDate = "CHANGE_DATE";


           
        }

        #endregion

        public int Id { get; set; }

        public int TimeoutChecking { get; set; }
        public string Name { get; set; }
        public string WsdlPath { get; set; }
        public DateTime? DeleteDate { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }

        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public MasterDataWcfInfo ShallowCopy()
        {
            return new MasterDataWcfInfo
            {
                Name = Name,
                TimeoutChecking = TimeoutChecking,
                WsdlPath = WsdlPath
            };
        }

       
    }
}

