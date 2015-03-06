using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings
{
    [DataContract]
    public class SysTableModel : BaseModel
	{
        [DataMember]
		public string description { get; set; }

        [DataMember]
        public int editMode { get; set; }
	}
}