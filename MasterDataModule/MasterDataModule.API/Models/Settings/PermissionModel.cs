using System.Runtime.Serialization;
using MasterDataModule.API.Validation;

namespace MasterDataModule.API.Models.Settings
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