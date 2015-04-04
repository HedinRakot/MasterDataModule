define([
	'base/related-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsPfpInspectionTypePfpPositionRsps',
    'l!t!TechnicalInspectionMasterData/AddInsPfpInspectionTypePfpPositionRsp'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'InsPfpInspectionTypePfpPositionRsps',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'insPfpInspectionTypeId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'insPfpPositionId', title: this.resources.insPfpPositionId },
				{ field: 'insPfpInspectionTypeId', title: this.resources.insPfpInspectionTypeId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.insPfpInspectionTypeId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
