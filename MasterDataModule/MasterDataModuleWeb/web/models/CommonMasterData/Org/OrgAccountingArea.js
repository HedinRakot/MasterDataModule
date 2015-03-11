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
		}
	});
	return model;
});
