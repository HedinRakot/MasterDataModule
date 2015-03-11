define([
    'router-master-data'
], function (MasterDataRouter) {
	'use strict';

	var createView = function (viewPath, collectionTypes, options) {
	    var d = $.Deferred();
	    require([viewPath], function (View) {
	        if (!!collectionTypes) {
	            require(['models/view-collection'], function (ViewCollection) {
	                ViewCollection.load(collectionTypes).done(function (viewCollection) {
	                    options = _.extend({}, options, viewCollection.toJSON());
	                    d.resolve(new View(options));
	                });
	            });
	        }
	        else
	            d.resolve(new View(options));
	    });

	    return d.promise();
	},
	createViewWithModel = function (viewPath, modelPath, collectionTypes, id) {
	    var d = $.Deferred();
	    require([modelPath], function (Model) {

	        var model = new Model();
	        if (_.isUndefined(id) || _.isNull(id)) {
	            createView(viewPath, collectionTypes, { model: model }).done(function (view) {
	                d.resolve(view);
	            });
	        }
	        else {
	            model.set(model.idAttribute, id);
	            model.fetch().done(function () {
	                createView(viewPath, collectionTypes, { model: model }).done(function (view) {
	                    d.resolve(view);
	                });
	            });
	        }
	    });

	    return d.promise();
	},
	showView = function (viewPath, collectionTypes, options) {
	    var self = this;
	    if (Application.user.get('isAuthenticated'))
	        createView(viewPath, collectionTypes, options).done(function (view) { self.trigger('router:view-created', view); });
	    else
	        showNotAuthenticated.call(self);
	},

	showViewWithModel = function (viewPath, modelPath, collectionTypes, id) {
	    var self = this;
	    if (Application.user.get('isAuthenticated'))
	        createViewWithModel(viewPath, modelPath, collectionTypes, id).done(function (view) { self.trigger('router:view-created', view); });
	    else
	        showNotAuthenticated.call(self);
	},

	showNotAuthenticated = function () {
	    var self = this;
	    require(['t!l!home/login'], function (View) {
	        self.trigger('router:view-created', new View);
	    });
	},

	router = Backbone.Router.extend({
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
				showView.call(self, 'l!t!errors/forbidden');
			});
		},

		routes: function() {
            
		    var commonRoutes =
            {
                'home': _.partial(showView, 'l!t!home/home'),

                'settings': _.partial(showView, 'l!t!settings/settings'),
                'permissions': _.partial(showView, 'l!t!settings/permissions'),
                'sysTables': _.partial(showView, 'l!t!settings/sysTables', { editModeTypes: true }),
                'roles': _.partial(showView, 'l!t!settings/roles', { permissions: true }),
                'users': _.partial(showView, 'l!t!settings/users', { roles: true }),
                'systemLog': _.partial(showView, 't!settings/systemLog'),


                'CommonMasterData': _.partial(showView, 'l!t!CommonMasterData/CommonMasterData'),
                'DriverLicenceMasterData': _.partial(showView, 'l!t!DriverLicenceMasterData/DriverLicenceMasterData'),
                'TechnicalInspectionMasterData': _.partial(showView, 'l!t!TechnicalInspectionMasterData/TechnicalInspectionMasterData'),
                'CustomerMasterData': _.partial(showView, 'l!t!CommonMasterData/Customer/CustomerMasterData'),
                'EmployeeMasterData': _.partial(showView, 'l!t!CommonMasterData/Employee/EmployeeMasterData'),
                'OrgMasterData': _.partial(showView, 'l!t!CommonMasterData/Org/OrgMasterData'),
                'ProductMasterData': _.partial(showView, 'l!t!CommonMasterData/Product/ProductMasterData'),
                'SystemMasterData': _.partial(showView, 'l!t!CommonMasterData/System/SystemMasterData'),
            };

		    debugger;
		    return $.extend({}, commonRoutes, MasterDataRouter.getAllMasterDataRoutes());
		}		
	});

	return router;
});