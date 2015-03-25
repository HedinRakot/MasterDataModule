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
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('kssExpenseGround', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('kssExpenseGround', 'toDate'), 
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
