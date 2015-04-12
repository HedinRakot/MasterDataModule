using MasterDataModule.API.Models.Settings;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Managers.Configuration;
using System;
using System.Web.Http;
using TuevSued.V1.IT.FE.CoreBase;

namespace MasterDataModule.API.Controllers.Settings
{
    public partial class MasterDataMonitorableInfoMasterDataNotificationsRspsController
    {
        protected void ExtraEntityToModel(MasterDataMonitorableInfoMasterDataNotificationsRsp entity, MasterDataMonitorableInfoMasterDataNotificationsRspModel model)
        {
            var monitorableInfoObject = String.Empty;
            var monitorableInfoTypeText = String.Empty;

            switch(entity.MonitorableInfoType)
            {
                case 1:

                    monitorableInfoTypeText = "Web-Service";

                    var masterDataWcfInfoManager = (IMasterDataWcfInfoManager)GlobalConfiguration.Configuration.
                        DependencyResolver.GetService(typeof(IMasterDataWcfInfoManager));

                    var wcfServiceInfo = masterDataWcfInfoManager.GetById(entity.MonitorableInfoId);

                    if(wcfServiceInfo != null)
                    {
                        monitorableInfoObject = wcfServiceInfo.Name;
                    }

                    break;
                case 2:

                    monitorableInfoTypeText = "Web-Site";

                    var masterDataSiteInfoManager = (IMasterDataSiteInfoManager)GlobalConfiguration.Configuration.
                        DependencyResolver.GetService(typeof(IMasterDataSiteInfoManager));

                    var siteInfo = masterDataSiteInfoManager.GetById(entity.MonitorableInfoId);

                    if (siteInfo != null)
                    {
                        monitorableInfoObject = siteInfo.Name;
                    }

                    break;
                case 3:

                    monitorableInfoTypeText = "Hintergrundprozess";

                    var masterDataJobInfoManager = (IMasterDataJobInfoManager)GlobalConfiguration.Configuration.
                        DependencyResolver.GetService(typeof(IMasterDataJobInfoManager));

                    var jobInfo = masterDataJobInfoManager.GetById(entity.MonitorableInfoId);

                    if (jobInfo != null)
                    {
                        monitorableInfoObject = jobInfo.Name;
                    }

                    break;
                case 4:

                    monitorableInfoTypeText = "Windows-Service";

                    var masterDataWindowsServiceInfoManager = (IMasterDataWindowsServiceInfoManager)GlobalConfiguration.Configuration.
                        DependencyResolver.GetService(typeof(IMasterDataWindowsServiceInfoManager));

                    var windowsServiceInfo = masterDataWindowsServiceInfoManager.GetById(entity.MonitorableInfoId);

                    if (windowsServiceInfo != null)
                    {
                        monitorableInfoObject = windowsServiceInfo.Name;
                    }

                    break;
                default:
                    throw new NotImplementedException();
            }

            model.monitorableInfoObject = monitorableInfoObject;
            model.monitorableInfoTypeText = monitorableInfoTypeText;
        }
    }
}
