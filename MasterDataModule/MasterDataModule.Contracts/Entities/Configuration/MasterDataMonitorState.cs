using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataMonitorState: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_MONITOR_STATE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataMonitorState.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'RECONFIGURE' for property <see cref="MasterDataMonitorState.Reconfigure"/>
            /// </summary>
            public static readonly string Reconfigure = "RECONFIGURE";
            /// <summary>
            /// Column name 'RECONFIGURE_CHECKING_TIMEOUT' for property <see cref="MasterDataMonitorState.ReconfigureCheckingTimeout"/>
            /// </summary>
            public static readonly string ReconfigureCheckingTimeout = "RECONFIGURE_CHECKING_TIMEOUT";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataMonitorState.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataMonitorState.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataMonitorState.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public bool? Reconfigure{ get; set; }
        public int ReconfigureCheckingTimeout{ get; set; }
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
        public MasterDataMonitorState ShallowCopy()
        {
            return new MasterDataMonitorState {
                       Reconfigure = Reconfigure,
                       ReconfigureCheckingTimeout = ReconfigureCheckingTimeout,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
        	           };
        }
    }
}
