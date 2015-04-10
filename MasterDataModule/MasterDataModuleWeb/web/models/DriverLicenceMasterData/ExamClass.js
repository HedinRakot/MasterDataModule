define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClasses',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamClass', 'name'), 
				                    validation: { required: true, maxLength: 10 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamClass', 'description'), 
				                    validation: { required: true, maxLength: 250 } }			
			,isMofa: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('ExamClass', 'isMofa'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ExamClass', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ExamClass', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,isFsClass: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('ExamClass', 'isFsClass'), 
				                    validation: { required: false } }			
			,sortOrder: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ExamClass', 'sortOrder'), 
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
