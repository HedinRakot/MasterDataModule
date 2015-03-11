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
			,sortOrder: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examStation', 'sortOrder'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
