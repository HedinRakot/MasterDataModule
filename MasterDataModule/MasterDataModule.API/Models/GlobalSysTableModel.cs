using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings
{
    [DataContract]
    public class GlobalSysTableModel
	{
        [DataMember]
        public Dictionary<string, SysTableWithColumnsModel> TableNames { get; set; }
	}

    [DataContract]
    public class SysTableWithColumnsModel
    {
        [DataMember]
        public int EditMode { get; set; }
        [DataMember]
        public List<string> ReadOnlyColumns { get; set; }
    }
}