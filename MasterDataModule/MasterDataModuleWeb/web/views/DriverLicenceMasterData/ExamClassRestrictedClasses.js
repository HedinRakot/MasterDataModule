define([
	'base/related-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClassRestrictedClasses',
    'l!t!DriverLicenceMasterData/AddExamClassRestrictedClass'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'ExamClassRestrictedClasses',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'examClassId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'examClassIdRestricted', title: this.resources.examClassIdRestricted , collection: this.options.examClass, filterable: false},
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
