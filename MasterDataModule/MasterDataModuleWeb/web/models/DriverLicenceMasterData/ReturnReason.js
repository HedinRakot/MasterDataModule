define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ReturnReasons',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('returnReason', 'name'), 
				                    validation: { required: true, maxLength: 50 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('returnReason', 'description'), 
				                    validation: { required: false, maxLength: 250 } }			
			,text1: { type: "string", 
			                        editable: Application.canTableItemBeEdit('returnReason', 'text1'), 
				                    validation: { required: false, maxLength: 200 } }			
			,text2: { type: "string", 
			                        editable: Application.canTableItemBeEdit('returnReason', 'text2'), 
				                    validation: { required: false, maxLength: 200 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('returnReason', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('returnReason', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
