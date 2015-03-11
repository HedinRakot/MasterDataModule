using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MasterDataModule.API.Models
{
    [DataContract]
	public class LoggedUserModel
	{
        [DataMember]
        public bool IsAuthenticated { get; set; }
        [DataMember]
        public Dictionary<string, bool> Permissions { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Login { get; set; }
	}
}