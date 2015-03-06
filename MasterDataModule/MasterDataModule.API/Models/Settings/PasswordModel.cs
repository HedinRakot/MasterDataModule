using TuevSued.V1.IT.FE.MasterDataModule.API.Validation;
using System.Runtime.Serialization;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings
{
	public interface IPasswordModel
	{
		string password { get; }
		string passwordConfirmation { get; }
	}

    [DataContract]
	public class PasswordModel : BaseModel, IPasswordModel
	{
        [DataMember]
        [Required]
		public string password { get; set; }
        [DataMember]
        [Required]
		public string passwordConfirmation { get; set; }
	}
}