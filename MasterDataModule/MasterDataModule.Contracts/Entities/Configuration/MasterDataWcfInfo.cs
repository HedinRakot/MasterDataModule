using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    /// <summary>
    ///     DE: Web-Services Einstellungen  EN: Wcf info
    /// </summary>
    public partial class MasterDataWcfInfo: IHasId<int>
        ,IHasTitle
        ,IIntervalFields
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
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="MasterDataWcfInfo.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="MasterDataWcfInfo.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'LOG_TYPE_INFO_ID' for property <see cref="MasterDataWcfInfo.LogTypeInfoId"/>
            /// </summary>
            public static readonly string LogTypeInfoId = "LOG_TYPE_INFO_ID";
          
        }
        #endregion
        public int Id{ get; set; }
        /// <summary>
        ///     DE: Name  EN: Name
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        ///     DE: Pfad to Wsdl  EN: Path to wsdl 
        /// </summary>
        public string WsdlPath{ get; set; }
        /// <summary>
        ///     DE: Timeout  EN: Timeout checking
        /// </summary>
        public int TimeoutChecking{ get; set; }
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
        public int? LogTypeInfoId{ get; set; }
        public virtual LogTypeInfo LogTypeInfo{ get; set; }
        public virtual ICollection<MasterDataWcfCheckResults> MasterDataWcfCheckResults{ get; set; }
        public bool HasLogTypeInfo
        {
            get { return !ReferenceEquals(LogTypeInfo, null); }
        }
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
        public MasterDataWcfInfo ShallowCopy()
        {
            return new MasterDataWcfInfo {
                       Name = Name,
                       WsdlPath = WsdlPath,
                       TimeoutChecking = TimeoutChecking,
                       CreateDate = CreateDate,
                       DeleteDate = DeleteDate,
                       ChangeDate = ChangeDate,
                       FromDate = FromDate,
                       ToDate = ToDate,
                       LogTypeInfoId = LogTypeInfoId,
        	           };
        }
    }
}
