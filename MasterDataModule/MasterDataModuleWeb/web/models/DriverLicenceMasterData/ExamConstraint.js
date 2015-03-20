define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamConstraints',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examConstraint', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examConstraint', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,constraintType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examConstraint', 'constraintType'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examConstraint', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examConstraint', 'toDate'), 
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
