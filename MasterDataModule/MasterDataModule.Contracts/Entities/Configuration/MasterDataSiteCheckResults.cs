using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataSiteCheckResults: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_SITE_CHECK_RESULTS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataSiteCheckResults.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'CHECK_STATUS' for property <see cref="MasterDataSiteCheckResults.CheckStatus"/>
            /// </summary>
            public static readonly string CheckStatus = "CHECK_STATUS";
            /// <summary>
            /// Column name 'CHECK_DATE' for property <see cref="MasterDataSiteCheckResults.CheckDate"/>
            /// </summary>
            public static readonly string CheckDate = "CHECK_DATE";
            /// <summary>
            /// Column name 'MESSAGE' for property <see cref="MasterDataSiteCheckResults.Message"/>
            /// </summary>
            public static readonly string Message = "MESSAGE";
            /// <summary>
            /// Column name 'ATTEMPT' for property <see cref="MasterDataSiteCheckResults.Attempt"/>
            /// </summary>
            public static readonly string Attempt = "ATTEMPT";
            /// <summary>
            /// Column name 'MASTER_DATA_SITE_INFO_ID' for property <see cref="MasterDataSiteCheckResults.MasterDataSiteInfoId"/>
            /// </summary>
            public static readonly string MasterDataSiteInfoId = "MASTER_DATA_SITE_INFO_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataSiteCheckResults.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataSiteCheckResults.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataSiteCheckResults.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public int? CheckStatus{ get; set; }
        public DateTime? CheckDate{ get; set; }
        public string Message{ get; set; }
        public int? Attempt{ get; set; }
        public int MasterDataSiteInfoId{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public virtual MasterDataSiteInfo MasterDataSiteInfo{ get; set; }
        public bool HasMasterDataSiteInfo
        {
            get { return !ReferenceEquals(MasterDataSiteInfo, null); }
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
        public MasterDataSiteCheckResults ShallowCopy()
        {
            return new MasterDataSiteCheckResults {
                       CheckStatus = CheckStatus,
                       CheckDate = CheckDate,
                       Message = Message,
                       Attempt = Attempt,
                       MasterDataSiteInfoId = MasterDataSiteInfoId,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
        	           };
        }
    }
}
