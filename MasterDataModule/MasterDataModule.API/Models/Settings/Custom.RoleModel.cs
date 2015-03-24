using System.Collections.Generic;
using System.Runtime.Serialization;
using MasterDataModule.API.Validation;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
	public partial class RoleModel
	{
        [DataMember]
        public IEnumerable<int> permissions { get; set; }
	}
}