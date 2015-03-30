using System.Runtime.Serialization;
using MasterDataModule.API.Validation;

namespace MasterDataModule.API.Models.Settings
{
	public partial class UserModel : IPasswordModel
	{
        [DataMember]
        [Required]
		public string passwordConfirmation { get; set; }
	}
}