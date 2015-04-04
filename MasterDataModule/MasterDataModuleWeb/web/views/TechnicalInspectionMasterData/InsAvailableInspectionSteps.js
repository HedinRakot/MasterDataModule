define([
	'base/related-object-grid-view',
    'collections/TechnicalInspectionMasterData/InsAvailableInspectionSteps',
    'l!t!TechnicalInspectionMasterData/AddInsAvailableInspectionStep'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'InsAvailableInspectionSteps',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'insInspectionStepId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'isMandatory', title: this.resources.isMandatory , headerTitle: this.resources.isMandatory, checkbox: true},
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.insInspectionStepId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
