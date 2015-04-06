using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataWcfInfo: IHasId<int>
        ,IRemovable
        ,ISystemFields
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
            /// Column name 'ID' for property <see cref="MasterDataWcfInfo.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="MasterDataWcfInfo.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'WSDL_PATH' for property <see cref="MasterDataWcfInfo.WsdlPath"/>
            /// </summary>
            public static readonly string WsdlPath = "WSDL_PATH";
            /// <summary>
            /// Column name 'TIMEOUT_CHECKING' for property <see cref="MasterDataWcfInfo.TimeoutChecking"/>
            /// </summary>
            public static readonly string TimeoutChecking = "TIMEOUT_CHECKING";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataWcfInfo.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataWcfInfo.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataWcfInfo.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string WsdlPath{ get; set; }
        public int TimeoutChecking{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public virtual ICollection<MasterDataWcfCheckResults> MasterDataWcfCheckResults{ get; set; }
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
        public MasterDataWcfInfo ShallowCopy()
        {
            return new MasterDataWcfInfo {
                       Name = Name,
                       WsdlPath = WsdlPath,
                       TimeoutChecking = TimeoutChecking,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
        	           };
        }
    }
}
