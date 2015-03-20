define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/CoreDataProductClassBases',
		fields: {
			id: { type: "number", editable: false }
			,examClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'examClassId'), 
				                    validation: { required: true } }			
			,coreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'coreDataProductId'), 
				                    validation: { required: true } }			
			,legalBasisId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'legalBasisId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,sortOrder: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'sortOrder'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
