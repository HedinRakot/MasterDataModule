define([
	'base/related-object-grid-view',
    'collections/Settings/MasterDataRolePermissionRsps',
    'l!t!Settings/AddMasterDataRolePermissionRsp'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'MasterDataRolePermissionRsps',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'masterDataRoleId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'masterDataRoleId', title: this.resources.masterDataRoleId , collection: this.options.role, defaultText: this.resources.pleaseSelect},
				{ field: 'masterDataPermissionId', title: this.resources.masterDataPermissionId , collection: this.options.permission, defaultText: this.resources.pleaseSelect},
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.masterDataRoleId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});