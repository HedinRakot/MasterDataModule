define([
	'base/related-object-grid-view',
	'collections/DriverLicenceMasterData/RequiredExamClasses'
], function (BaseView, Collection) {
	'use strict';

	var view = BaseView.extend({
		
	    collectionType: Collection,
		gridSelector: '.required-classes',
		tableName: 'requiredExamClass',

		initialize: function () {
            
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'examClassId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {

			return [
				{
				    field: 'requiredExamClassId', title: this.resources.requiredExamClass,
				    collection: this.options.examClasses,
				    defaultText: 'Fahrerlaubnisklasse auswählen',
				    filterable: false
				},
                { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
			];
		},

		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {

		        e.model.examClassId = self.model.id;
		    });

		    return self;
		},
	});

	return view;
});