define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/KssExpenseGrounds',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('kssExpenseGround', 'description'), 
				                    validation: { required: true, maxLength: 50 } }			
			,account: { type: "string", 
			                        editable: Application.canTableItemBeEdit('kssExpenseGround', 'account'), 
				                    validation: { required: false, maxLength: 10 } }			
			,insVatTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('kssExpenseGround', 'insVatTypeId'), 
				                    validation: { required: false } }			
			,maxAmount: { type: "number", 
			                        editable: Application.canTableItemBeEdit('kssExpenseGround', 'maxAmount'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
