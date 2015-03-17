define([
	'base/related-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClassArgeMaps',
    'l!t!DriverLicenceMasterData/AddExamClassArgeMap'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'ExamClassArgeMaps',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'examClassId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'examNameArge', title: this.resources.examNameArge },
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
