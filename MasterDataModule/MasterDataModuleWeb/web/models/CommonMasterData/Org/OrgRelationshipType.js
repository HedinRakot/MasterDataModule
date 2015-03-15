define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgRelationshipTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgRelationshipType', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgRelationshipType', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgRelationshipType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgRelationshipType', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
