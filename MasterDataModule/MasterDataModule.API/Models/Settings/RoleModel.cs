using System.Collections.Generic;
using System.Runtime.Serialization;
using MasterDataModule.API.Validation;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
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