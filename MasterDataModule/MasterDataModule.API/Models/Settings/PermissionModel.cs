using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings
{
    [DataContract]
	public class PermissionModel: BaseModel
	{
        [DataMember]
        [Required]
		public string name { get; set; }

        [DataMember]
        public string systemName { get; set; }
	}
}