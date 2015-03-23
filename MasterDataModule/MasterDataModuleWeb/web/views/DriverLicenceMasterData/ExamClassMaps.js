define([
	'base/related-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClassMaps',
    'l!t!DriverLicenceMasterData/AddExamClassMap'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'ExamClassMaps',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'examClassIdOld', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'examClassIdActual', title: this.resources.examClassIdActual , collection: this.options.examClass, defaultText: this.resources.pleaseSelect},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.examClassIdOld = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
