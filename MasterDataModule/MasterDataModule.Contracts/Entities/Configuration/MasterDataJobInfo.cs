using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataJobInfo: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_JOB_INFO";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataJobInfo.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'CONNECTION_STRING' for property <see cref="MasterDataJobInfo.ConnectionString"/>
            /// </summary>
            public static readonly string ConnectionString = "CONNECTION_STRING";
            /// <summary>
            /// Column name 'TABLE_NAME' for property <see cref="MasterDataJobInfo.TableName"/>
            /// </summary>
            public static readonly string TableName = "TABLE_NAME";
            /// <summary>
            /// Column name 'TIMEOUT_CHECKING' for property <see cref="MasterDataJobInfo.TimeoutChecking"/>
            /// </summary>
            public static readonly string TimeoutChecking = "TIMEOUT_CHECKING";
            /// <summary>
            /// Column name 'NAME' for property <see cref="MasterDataJobInfo.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'JOB_NAME' for property <see cref="MasterDataJobInfo.JobName"/>
            /// </summary>
            public static readonly string JobName = "JOB_NAME";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataJobInfo.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataJobInfo.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataJobInfo.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public string ConnectionString{ get; set; }
        public string TableName{ get; set; }
        public int TimeoutChecking{ get; set; }
        public string Name{ get; set; }
        public string JobName{ get; set; }
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
        public MasterDataJobInfo ShallowCopy()
        {
            return new MasterDataJobInfo {
                       ConnectionString = ConnectionString,
                       TableName = TableName,
                       TimeoutChecking = TimeoutChecking,
                       Name = Name,
                       JobName = JobName,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
        	           };
        }
    }
}
