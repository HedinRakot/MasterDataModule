define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClassRequiredClasses',
		fields: {
			id: { type: "number", editable: false }
			,examClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClassRequiredClass', 'examClassId'), 
				                    validation: { required: true } }			
			,examClassIdRequired: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examClassRequiredClass', 'examClassIdRequired'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examClassRequiredClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examClassRequiredClass', 'toDate'), 
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
