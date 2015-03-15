define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SysPostCodes',
		fields: {
			id: { type: "number", editable: false }
			,postCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysPostCode', 'postCode'), 
				                    validation: { required: true, maxLength: 10 } }			
			,city: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysPostCode', 'city'), 
				                    validation: { required: false, maxLength: 50 } }			
			,street: { type: "string", 
			                        editable: Application.canTableItemBeEdit('sysPostCode', 'street'), 
				                    validation: { required: false, maxLength: 50 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysPostCode', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('sysPostCode', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
