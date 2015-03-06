define([
	'base/related-object-grid-view',
	'collections/CommonMasterData/EmpEmployeeSysRoleRsps'
], function (BaseView, Collection) {
	'use strict';

	var view = BaseView.extend({
		
	    collectionType: Collection,
	    gridSelector: '.empEmployeeSysRoleRsps',
	    tableName: 'empEmployeeSysRoleRsp',

		initialize: function () {
            
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'empEmployeeId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {

			return [
				{
				    field: 'sysRoleId', title: this.resources.sysRoleId,
				    collection: this.options.sysRoles,
				    defaultText: 'Rolle auswählen',
				    filterable: false
				},
                { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
			];
		},

		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {

		        e.model.sysRoleId = self.model.id;
		    });

		    return self;
		},
	});

	return view;
});