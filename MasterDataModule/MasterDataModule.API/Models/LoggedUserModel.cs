using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings
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