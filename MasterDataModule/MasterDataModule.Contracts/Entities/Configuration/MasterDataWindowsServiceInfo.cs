using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataWindowsServiceInfo: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_WINDOWS_SERVICE_INFO";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataWindowsServiceInfo.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="MasterDataWindowsServiceInfo.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'MACHINE_NAME' for property <see cref="MasterDataWindowsServiceInfo.MachineName"/>
            /// </summary>
            public static readonly string MachineName = "MACHINE_NAME";
            /// <summary>
            /// Column name 'SERVICE_NAME' for property <see cref="MasterDataWindowsServiceInfo.ServiceName"/>
            /// </summary>
            public static readonly string ServiceName = "SERVICE_NAME";
            /// <summary>
            /// Column name 'TIMEOUT_CHECKING' for property <see cref="MasterDataWindowsServiceInfo.TimeoutChecking"/>
            /// </summary>
            public static readonly string TimeoutChecking = "TIMEOUT_CHECKING";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataWindowsServiceInfo.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataWindowsServiceInfo.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataWindowsServiceInfo.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string MachineName{ get; set; }
        public string ServiceName{ get; set; }
        public int TimeoutChecking{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public virtual ICollection<MasterDataWindowsServiceCheckResults> MasterDataWindowsServiceCheckResults{ get; set; }
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
        public MasterDataWindowsServiceInfo ShallowCopy()
        {
            return new MasterDataWindowsServiceInfo {
                       Name = Name,
                       MachineName = MachineName,
                       ServiceName = ServiceName,
                       TimeoutChecking = TimeoutChecking,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
        	           };
        }
    }
}
