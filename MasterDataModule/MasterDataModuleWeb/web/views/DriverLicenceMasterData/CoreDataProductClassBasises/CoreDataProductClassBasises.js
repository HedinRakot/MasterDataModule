define([
	'base/related-object-grid-view',
	'collections/DriverLicenceMasterData/CoreDataProductClassBasises',
], function (BaseView, Collection) {
	'use strict';

	var view = BaseView.extend({

		collectionType: Collection,
		gridSelector: '.classes-legalbasises',
		tableName: 'coreDataProductClassBasis',
        
		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'coreDataProductId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
			return [
				{
				    field: 'examClassId', title: this.resources.examClass,
				    collection: this.options.examClasses, filterable: false,
				    defaultText: 'Fahrerlaubnisklasse auswählen',
				},
                {
                    field: 'legalBasisId', title: this.resources.legalBasis,
                    collection: this.options.legalBasises, filterable: false,
                    defaultText: 'Rechtsgrund auswählen',
                },
                { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
		        { field: 'sortOrder', title: this.resources.sortOrder },
			];
		},

		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.coreDataProductId = self.model.id;
		    });

		    return self;
		},
	});

	return view;
});