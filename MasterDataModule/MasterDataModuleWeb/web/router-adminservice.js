define([
    'base-router'
], function (BaseRouter) {
    'use strict';

    var factory = {

        getAllMasterDataRoutes: function (baseRouter) {
            var routes = {
                'WebServiceMonitor': _.partial(BaseRouter.showView, baseRouter, 'l!t!AdminService/WebServiceMonitor', { SysLanguage: true }),
                'JobMonitor': _.partial(BaseRouter.showView, baseRouter, 'l!t!AdminService/JobMonitor', { SysLanguage: true }),                
                'WinServiceMonitor': _.partial(BaseRouter.showView, baseRouter, 'l!t!AdminService/WinServiceMonitor', { SysLanguage: true }),
                'WebSiteMonitor': _.partial(BaseRouter.showView, baseRouter, 'l!t!AdminService/WebSiteMonitor', { SysLanguage: true }),
                'ApplicationLogToShow': _.partial(BaseRouter.showView, baseRouter, 'l!t!AdminService/ApplicationLogToShow', { SysLanguage: true }),
                'ApplicationLogToShow/:id': _.partial(BaseRouter.showView, baseRouter, 'l!t!AdminService/ApplicationLogToShow', { SysLanguage: true }),
                'Monitoring': _.partial(BaseRouter.showView, baseRouter, 'l!t!AdminService/Monitoring')
            }

            return routes;
        }
    };

    return factory;
});
