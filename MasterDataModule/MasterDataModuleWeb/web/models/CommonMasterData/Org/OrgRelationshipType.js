define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgRelationshipTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('OrgRelationshipType', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('OrgRelationshipType', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrgRelationshipType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrgRelationshipType', 'toDate'), 
				                    validation: { required: true, date: true } }			
		},
		defaults: function () {
			var dnf = new Date();
			var dnt = new Date(2070,11,31);
			return {
				fromDate: dnf, 
				toDate: dnt
			};
		}
	});
	return model;
});
