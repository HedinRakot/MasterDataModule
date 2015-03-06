using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings
{
    [DataContract]
	public class RoleModel: BaseModel
	{
        [DataMember]
        [Required]
		public string name { get; set; }

        [DataMember]
        public IEnumerable<int> permissions { get; set; }
	}
}