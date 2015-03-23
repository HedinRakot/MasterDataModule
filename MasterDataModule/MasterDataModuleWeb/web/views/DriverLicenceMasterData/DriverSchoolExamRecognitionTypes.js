define([
	'base/related-object-grid-view',
    'collections/DriverLicenceMasterData/DriverSchoolExamRecognitionTypes',
    'l!t!DriverLicenceMasterData/AddDriverSchoolExamRecognitionType'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'DriverSchoolExamRecognitionTypes',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'driverSchoolId', operator: 'eq', value: this.model.id };

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
		        e.model.driverSchoolId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
