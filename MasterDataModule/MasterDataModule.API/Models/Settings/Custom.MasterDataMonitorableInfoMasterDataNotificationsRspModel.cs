using System.Runtime.Serialization;
using MasterDataModule.API.Validation;

namespace MasterDataModule.API.Models.Settings
{
    public partial class MasterDataMonitorableInfoMasterDataNotificationsRspModel
	{
        [DataMember]
        public string monitorableInfoObject { get; set; }
        
        [DataMember]
        public string monitorableInfoTypeText { get; set; }
	}
}