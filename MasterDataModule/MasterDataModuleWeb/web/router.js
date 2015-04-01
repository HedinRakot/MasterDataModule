define([
    'base-router',
    'router-drl-masterdata',
    'router-tp-masterdata',
    'router-common-masterdata',
    'router-masterdata',
    'router-adminservice'
], function (BaseRouter, FeMasterDataRouter, TPMasterDataRouter, CommonMasterDataRouter, MasterDataRouter, AdminServiceRouter) {
	'use strict';

	var router = Backbone.Router.extend({
		initialize: function (options) {
			var self = this;
			this.masterView = options.masterView;
			this.listenTo(Backbone, 'logged-in', function () {

				location.reload();
			});
			this.listenTo(Backbone, 'logged-out', function () {
				location.reload();
			});
			this.listenTo(Backbone, 'forbidden', function () {
			    BaseRouter.showView.call(self, 'l!t!errors/forbidden');
			});
		},

		routes: function() {

		    var commonRoutes =
            {
                'home': _.partial(BaseRouter.showView, this, 'l!t!home/home'),

                'Settings': _.partial(BaseRouter.showView, this, 'l!t!Settings/Settings'),
                //'permissions': _.partial(BaseRouter.showView, this, 'l!t!settings/permissions'),
                'sysTables': _.partial(BaseRouter.showView, this, 'l!t!settings/sysTables', { editModeTypes: true }),
                //'roles': _.partial(BaseRouter.showView, this, 'l!t!settings/roles', { permissions: true }),
                'users': _.partial(BaseRouter.showView, this, 'l!t!settings/users', { roles: true }),
                'systemLog': _.partial(BaseRouter.showView, this, 't!settings/systemLog'),


                'CommonMasterData': _.partial(BaseRouter.showView, this, 'l!t!CommonMasterData/CommonMasterData'),
                'AdminService': _.partial(BaseRouter.showView, this, 'l!t!AdminService/AdminService'),
                'DriverLicenceMasterData': _.partial(BaseRouter.showView, this, 'l!t!DriverLicenceMasterData/DriverLicenceMasterData'),
                'TechnicalInspectionMasterData': _.partial(BaseRouter.showView, this, 'l!t!TechnicalInspectionMasterData/TechnicalInspectionMasterData'),
                'CustomerMasterData': _.partial(BaseRouter.showView, this, 'l!t!CommonMasterData/Customer/CustomerMasterData'),
                'EmployeeMasterData': _.partial(BaseRouter.showView, this, 'l!t!CommonMasterData/Employee/EmployeeMasterData'),
                'OrgMasterData': _.partial(BaseRouter.showView, this, 'l!t!CommonMasterData/Org/OrgMasterData'),
                'ProductMasterData': _.partial(BaseRouter.showView, this, 'l!t!CommonMasterData/Product/ProductMasterData'),
                'SystemMasterData': _.partial(BaseRouter.showView, this, 'l!t!CommonMasterData/System/SystemMasterData'),
            };
		    
		    var result = $.extend({}, commonRoutes, FeMasterDataRouter.getAllMasterDataRoutes(this));
		    result = $.extend({}, result, TPMasterDataRouter.getAllMasterDataRoutes(this));
		    result = $.extend({}, result, CommonMasterDataRouter.getAllMasterDataRoutes(this));
		    result = $.extend({}, result, MasterDataRouter.getAllMasterDataRoutes(this));
		    result = $.extend({}, result, AdminServiceRouter.getAllMasterDataRoutes(this));
		    return result;
		}		
	});

	return router;
});