define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClassMaps',
		fields: {
			id: { type: "number", editable: false }
			,examClassIdOld: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ExamClassMap', 'examClassIdOld'), 
				                    validation: { required: true } }			
			,examClassIdActual: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ExamClassMap', 'examClassIdActual'), 
				                    validation: { required: true } }			
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
