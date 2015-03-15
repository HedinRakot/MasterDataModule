define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsObdStatuses',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insObdStatus', 'name'), 
				                    validation: { required: true, maxLength: 3 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insObdStatus', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,auView: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insObdStatus', 'auView'), 
				                    validation: { required: true, maxLength: 1 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insObdStatus', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insObdStatus', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
