﻿define(function () {
	'use strict';

	var getInsCoreDataProductEditView = function () {
        var d = new $.Deferred();

        require([
            'l!t!CommonMasterData/Product/InsCoreDataProducts/AddInsCoreDataProduct',
            'models/CommonMasterData/Product/InsCoreDataProduct',
			'models/view-collection'
        ], function (View, Model, ViewCollection) {
            var model = new Model(),
	            options = _.extend({}, {
	                model: model
	            });

            ViewCollection.load({
                sysLanguages: true
            }).done(function (viewCollection) {
                options = _.extend(options, viewCollection.toJSON());

                d.resolve(new View(options));
            });
        });

        return d.promise();
	},

	getEmpEmployeeEditView = function () {
	    var d = new $.Deferred();

	    require([
            'l!t!CommonMasterData/Employee/EmpEmployees/AddEmpEmployee',
            'models/CommonMasterData/Employee/EmpEmployee',
			'models/view-collection'
	    ], function (View, Model, ViewCollection) {
	        var model = new Model(),
	            options = _.extend({}, {
	                model: model
	            });

	        ViewCollection.load({

	        }).done(function (viewCollection) {
	            options = _.extend(options, viewCollection.toJSON());

	            d.resolve(new View(options));
	        });
	    });

	    return d.promise();
	},
            getOrgUnitEditView = function() {
	        var d = new $.Deferred();

	        require([
	            'l!t!CommonMasterData/Org/OrganizationalUnits/AddOrganizationalUnit',
	            'models/CommonMasterData/Org/OrganizationalUnits/OrganizationalUnit',
	            'models/view-collection'
	        ], function(View, Model, ViewCollection) {
	            var model = new Model(),
	                options = _.extend({}, {
	                    model: model
	                });

	            ViewCollection.load({
	                accountingAreas: true,
                    orgTypes: true
	            }).done(function(viewCollection) {
	                options = _.extend(options, viewCollection.toJSON());

	                d.resolve(new View(options));
	            });
	        });

	        return d.promise();
	    },
    
	factory = {
	    
	    getInsCoreDataProductCreateView: function () {
	        return getInsCoreDataProductEditView();
	    },
	    getInsCoreDataProductEditView: function (id) {
	        var d = new $.Deferred();
	        getInsCoreDataProductEditView().done(function (view) {

	            view.model.set({ 'id': id });
                
	            view.model.fetch().done(function () {
	                d.resolve(view);
	            });
	        });

	        return d.promise();
	    },
	    getEmpEmployeeCreateView: function () {
	        return getEmpEmployeeEditView();
	    },
	    getEmpEmployeeEditView: function (id) {
	        var d = new $.Deferred();
	        getEmpEmployeeEditView().done(function (view) {
	            
	            view.model.set({ 'id': id });
                
	            view.model.fetch().done(function () {
	                d.resolve(view);
	            });
	        });

	        return d.promise();
	    },
	    getOrgUnitCreateView: function () {
	        return getOrgUnitEditView();
	    },
	    getOrgUnitEditView: function (id) {
	        var d = new $.Deferred();
	        getOrgUnitEditView().done(function (view) {

	            view.model.set({ 'id': id });

	            view.model.fetch().done(function () {
	                d.resolve(view);
	            });
	        });

	        return d.promise();
	    },
	};

    return factory;
});