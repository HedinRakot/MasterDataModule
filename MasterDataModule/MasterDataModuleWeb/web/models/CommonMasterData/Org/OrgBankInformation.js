define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgBankInformation',
		fields: {
			id: { type: "number", editable: false }
			,bankName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgBankInformation', 'bankName'), 
				                    validation: { required: true, maxLength: 250 } }			
			,bankCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgBankInformation', 'bankCode'), 
				                    validation: { required: true, maxLength: 250 } }			
			,bankAccount: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgBankInformation', 'bankAccount'), 
				                    validation: { required: true, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgBankInformation', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgBankInformation', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
