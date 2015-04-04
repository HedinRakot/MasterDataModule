define([
	'base/related-object-grid-view',
    'collections/CommonMasterData/Employee/EmpEmployeeSysRoleRsps',
    'l!t!CommonMasterData/Employee/AddEmpEmployeeSysRoleRsp'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'EmpEmployeeSysRoleRsps',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'empEmployeeId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'sysRoleId', title: this.resources.sysRoleId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.empEmployeeId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
