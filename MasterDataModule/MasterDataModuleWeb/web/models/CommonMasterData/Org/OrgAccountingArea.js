define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgAccountingAreas',
		fields: {
			id: { type: "number", editable: false }
			,accountingArea: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgAccountingArea', 'accountingArea'), 
				                    validation: { required: true, maxLength: 4 } }			
			,maxOrderSum: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgAccountingArea', 'maxOrderSum'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgAccountingArea', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgAccountingArea', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
