define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClassMaps',
		fields: {
			id: { type: "number", editable: false }
			,examClassIdOld: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClassMap', 'examClassIdOld'), 
				                    validation: { required: true } }			
			,examClassIdActual: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClassMap', 'examClassIdActual'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
