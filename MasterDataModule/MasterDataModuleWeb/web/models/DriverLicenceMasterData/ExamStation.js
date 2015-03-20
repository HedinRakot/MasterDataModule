define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamStations',
		fields: {
			id: { type: "number", editable: false }
			,ordFederalStateId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examStation', 'ordFederalStateId'), 
				                    validation: { required: false } }			
			,place: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examStation', 'place'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examStation', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examStation', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examStation', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,sortOrder: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examStation', 'sortOrder'), 
				                    validation: { required: false } }			
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
