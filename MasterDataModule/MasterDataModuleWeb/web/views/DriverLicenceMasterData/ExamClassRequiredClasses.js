define([
	'base/related-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClassRequiredClasses',
    'l!t!DriverLicenceMasterData/AddExamClassRequiredClass'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'ExamClassRequiredClasses',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'examClassId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'examClassIdRequired', title: this.resources.examClassIdRequired , collection: this.options.examClass, defaultText: this.resources.pleaseSelect},
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.examClassId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
