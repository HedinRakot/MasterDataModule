define([
	'base/related-object-grid-view',
    'collections/CommonMasterData/Org/OrgCostCenterResponsibleEmployeeRsps',
    'l!t!CommonMasterData/Org/AddOrgCostCenterResponsibleEmployeeRsp'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'OrgCostCenterResponsibleEmployeeRsps',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'orgCostCenterId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'empEmployeeId', title: this.resources.empEmployeeId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.orgCostCenterId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});