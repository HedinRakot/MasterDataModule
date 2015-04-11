define([
    'base-router'
], function (BaseRouter) {
    'use strict';

    var factory = {

        getAllMasterDataRoutes: function (baseRouter) {
            var routes = {
                'WebServiceMonitor': _.partial(BaseRouter.showView, baseRouter, 'l!t!AdminService/WebServiceMonitor/WebServiceMonitor', { SysLanguage: true }),
                'JobMonitor': _.partial(BaseRouter.showView, baseRouter, 'l!t!AdminService/JobMonitor/JobMonitor', { SysLanguage: true }),                
            }

            return routes;
        }
    };

    return factory;
});
