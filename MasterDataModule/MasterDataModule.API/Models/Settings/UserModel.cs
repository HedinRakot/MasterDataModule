using System.Runtime.Serialization;
using MasterDataModule.API.Validation;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    [DataContract]
	public class UserModel : BaseModel, IPasswordModel
	{
        [DataMember]
        [Required]
        public string name { get; set; }
        [DataMember]
        [Required]
        public string login { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string passwordConfirmation { get; set; }
        [DataMember]
        public int role { get; set; }
	}
}