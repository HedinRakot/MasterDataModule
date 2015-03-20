define([
	'base/related-object-grid-view',
    'collections/CommonMasterData/Product/OrdRecognitionAreaOfWorkRsps',
    'l!t!CommonMasterData/Product/AddOrdRecognitionAreaOfWorkRsp'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'OrdRecognitionAreaOfWorkRsps',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'ordRecognitionId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'ordAreaOfWorkId', title: this.resources.ordAreaOfWorkId },
				{ field: 'priority', title: this.resources.priority },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.ordRecognitionId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
