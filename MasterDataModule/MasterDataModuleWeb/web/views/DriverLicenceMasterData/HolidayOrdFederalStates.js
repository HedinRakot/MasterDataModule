define([
	'base/related-object-grid-view',
    'collections/DriverLicenceMasterData/HolidayOrdFederalStates',
    'l!t!DriverLicenceMasterData/AddHolidayOrdFederalState'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'HolidayOrdFederalStates',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'holidayId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'ordFederalStateId', title: this.resources.ordFederalStateId , collection: this.options.ordFederalState, filterable: false},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.holidayId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
