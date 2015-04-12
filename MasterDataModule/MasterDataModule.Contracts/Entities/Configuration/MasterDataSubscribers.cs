using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataSubscribers: IHasId<int>
        ,IHasTitle
        ,IRemovable
        ,ISystemFields
    {
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "dbo.MASTER_DATA_SUBSCRIBERS";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="MasterDataSubscribers.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'EMAIL' for property <see cref="MasterDataSubscribers.Email"/>
            /// </summary>
            public static readonly string Email = "EMAIL";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="MasterDataSubscribers.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="MasterDataSubscribers.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="MasterDataSubscribers.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
          
        }
        #endregion
        public int Id{ get; set; }
        public string Email{ get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ChangeDate{ get; set; }
        public DateTime? DeleteDate{ get; set; }
        public virtual ICollection<MasterDataNotificationsMasterDataSubscribersRsp> MasterDataNotificationsMasterDataSubscribersRsps{ get; set; }
        string IHasTitle.EntityTitle
        {
            get { return Email; }
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
        public MasterDataSubscribers ShallowCopy()
        {
            return new MasterDataSubscribers {
                       Email = Email,
                       CreateDate = CreateDate,
                       ChangeDate = ChangeDate,
                       DeleteDate = DeleteDate,
        	           };
        }
    }
}
