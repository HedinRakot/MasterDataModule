define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/HolidayOrdFederalStates',
		fields: {
			id: { type: "number", editable: false }
			,holidayId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('holidayOrdFederalState', 'holidayId'), 
				                    validation: { required: true } }			
			,ordFederalStateId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('holidayOrdFederalState', 'ordFederalStateId'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
