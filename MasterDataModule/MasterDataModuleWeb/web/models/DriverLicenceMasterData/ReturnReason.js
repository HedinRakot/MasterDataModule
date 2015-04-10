define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ReturnReasons',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ReturnReason', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ReturnReason', 'description'), 
				                    validation: { required: true, maxLength: 250 } }			
			,text1: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ReturnReason', 'text1'), 
				                    validation: { required: false, maxLength: 200 } }			
			,text2: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ReturnReason', 'text2'), 
				                    validation: { required: false, maxLength: 200 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ReturnReason', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ReturnReason', 'toDate'), 
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
