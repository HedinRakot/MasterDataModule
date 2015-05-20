define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsUnitCodes',
		fields: {
			id: { type: "number", editable: false }
			,orgAccountingAreaId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsUnitCode', 'orgAccountingAreaId'), 
				                    validation: { required: true } }			
			,ordFederalStateId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsUnitCode', 'ordFederalStateId'), 
				                    validation: { required: true } }			
			,ordAreaOfWorkId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsUnitCode', 'ordAreaOfWorkId'), 
				                    validation: { required: true } }			
			,unitCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsUnitCode', 'unitCode'), 
				                    validation: { required: false, maxLength: 8 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsUnitCode', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsUnitCode', 'toDate'), 
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
