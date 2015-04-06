using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataJobCheckResults: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_JOB_CHECK_RESULTS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataJobCheckResults.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'LAST_RUN_TIME' for property <see cref="MasterDataJobCheckResults.LastRunTime"/>
            /// </summary>
            public static readonly string LastRunTime = "LAST_RUN_TIME";
            /// <summary>
            /// Column name 'CHECK_DATE' for property <see cref="MasterDataJobCheckResults.CheckDate"/>
            /// </summary>
            public static readonly string CheckDate = "CHECK_DATE";
            /// <summary>
            /// Column name 'CHECK_STATUS' for property <see cref="MasterDataJobCheckResults.CheckStatus"/>
            /// </summary>
            public static readonly string CheckStatus = "CHECK_STATUS";
            /// <summary>
            /// Column name 'MASTER_DATA_JOB_INFO_ID' for property <see cref="MasterDataJobCheckResults.MasterDataJobInfoId"/>
            /// </summary>
            public static readonly string MasterDataJobInfoId = "MASTER_DATA_JOB_INFO_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataJobCheckResults.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataJobCheckResults.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataJobCheckResults.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public DateTime? LastRunTime{ get; set; }
        public DateTime? CheckDate{ get; set; }
        public int? CheckStatus{ get; set; }
        public int MasterDataJobInfoId{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
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
        public MasterDataJobCheckResults ShallowCopy()
        {
            return new MasterDataJobCheckResults {
                       LastRunTime = LastRunTime,
                       CheckDate = CheckDate,
                       CheckStatus = CheckStatus,
                       MasterDataJobInfoId = MasterDataJobInfoId,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
        	           };
        }
    }
}
