define([
	'base/related-object-grid-view',
    'collections/DriverLicenceMasterData/MeetingPointOrganizationalUnits',
    'l!t!DriverLicenceMasterData/AddMeetingPointOrganizationalUnit'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'MeetingPointOrganizationalUnits',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'meetingPointId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'orgOrganizationalUnitId', title: this.resources.orgOrganizationalUnitId , collection: this.options.orgOrganizationalUnit, filterable: false},
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.meetingPointId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
