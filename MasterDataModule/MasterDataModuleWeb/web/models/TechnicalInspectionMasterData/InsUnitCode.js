define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsUnitCodes',
		fields: {
			id: { type: "number", editable: false }
			,orgAccountingAreaId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insUnitCode', 'orgAccountingAreaId'), 
				                    validation: { required: true } }			
			,ordFederalStateId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insUnitCode', 'ordFederalStateId'), 
				                    validation: { required: true } }			
			,ordAreaOfWorkId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insUnitCode', 'ordAreaOfWorkId'), 
				                    validation: { required: true } }			
			,unitCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insUnitCode', 'unitCode'), 
				                    validation: { required: false, maxLength: 8 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insUnitCode', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insUnitCode', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
