define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgAccountingAreas',
		fields: {
			id: { type: "number", editable: false }
			,accountingArea: { type: "string", 
			                        editable: Application.canTableItemBeEdit('OrgAccountingArea', 'accountingArea'), 
				                    validation: { required: true, maxLength: 4 } }			
			,maxOrderSum: { type: "number", 
			                        editable: Application.canTableItemBeEdit('OrgAccountingArea', 'maxOrderSum'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrgAccountingArea', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('OrgAccountingArea', 'toDate'), 
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
