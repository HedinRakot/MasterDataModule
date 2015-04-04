define([
	'base/related-object-grid-view',
    'collections/DriverLicenceMasterData/ExamStationExamRecognitionTypes',
    'l!t!DriverLicenceMasterData/AddExamStationExamRecognitionType'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'ExamStationExamRecognitionTypes',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'examStationId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'examRecognitionTypeId', title: this.resources.examRecognitionTypeId , collection: this.options.examRecognitionType, defaultText: this.resources.pleaseSelect},
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.examStationId = self.model.id;

				if (e.model.isNew()) {
                    var dt = new Date(2070, 11, 31);
		            e.model.toDate = dt;
		            var numeric = e.container.find("input[name=toDate]");
		            numeric[0].value = dt.toLocaleDateString();
		        }
		    });

		    return self;
		}
	});

	return view;
});
