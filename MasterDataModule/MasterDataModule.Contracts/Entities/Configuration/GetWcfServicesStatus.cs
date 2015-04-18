using MasterDataModule.Contracts;
using System;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class GetWcfServicesStatus: IHasId<int>
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.GET_WCF_SERVICES_STATUS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="GetWcfServicesStatus.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'CHECK_STATUS' for property <see cref="GetWcfServicesStatus.CheckStatus"/>
            /// </summary>
            public static readonly string CheckStatus = "CHECK_STATUS";
            /// <summary>
            /// Column name 'CHECK_DATE' for property <see cref="GetWcfServicesStatus.CheckDate"/>
            /// </summary>
            public static readonly string CheckDate = "CHECK_DATE";
            /// <summary>
            /// Column name 'MESSAGE' for property <see cref="GetWcfServicesStatus.Message"/>
            /// </summary>
            public static readonly string Message = "MESSAGE";
            /// <summary>
            /// Column name 'ATTEMPT' for property <see cref="GetWcfServicesStatus.Attempt"/>
            /// </summary>
            public static readonly string Attempt = "ATTEMPT";
            /// <summary>
            /// Column name 'NAME' for property <see cref="GetWcfServicesStatus.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'WSDL_PATH' for property <see cref="GetWcfServicesStatus.WsdlPath"/>
            /// </summary>
            public static readonly string WsdlPath = "WSDL_PATH";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="GetWcfServicesStatus.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="GetWcfServicesStatus.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="GetWcfServicesStatus.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'LOG_TYPE_INFO_ID' for property <see cref="GetWcfServicesStatus.LogTypeInfoId"/>
            /// </summary>
            public static readonly string LogTypeInfoId = "LOG_TYPE_INFO_ID";
          
        }
        #endregion
        public int Id{ get; set; }
        public int? CheckStatus{ get; set; }
        public DateTime? CheckDate{ get; set; }
        public string Message{ get; set; }
        public int? Attempt{ get; set; }
        public string Name{ get; set; }
        public string WsdlPath{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public int? LogTypeInfoId{ get; set; }
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
        public GetWcfServicesStatus ShallowCopy()
        {
            return new GetWcfServicesStatus {
                       Id = Id,
                       CheckStatus = CheckStatus,
                       CheckDate = CheckDate,
                       Message = Message,
                       Attempt = Attempt,
                       Name = Name,
                       WsdlPath = WsdlPath,
                       DeleteDate = DeleteDate,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       LogTypeInfoId = LogTypeInfoId,
        	           };
        }
    }
}
