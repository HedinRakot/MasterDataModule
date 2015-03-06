using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings
{
    [DataContract]
    public class SystemLogRecordModel : BaseModel
	{
        [DataMember]
        public string userLogin { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public DateTime date { get; set; }
	}
}