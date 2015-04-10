define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/CoreDataProductClassBases',
		fields: {
			id: { type: "number", editable: false }
			,examClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductClassBasis', 'examClassId'), 
				                    validation: { required: true } }			
			,coreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductClassBasis', 'coreDataProductId'), 
				                    validation: { required: true } }			
			,legalBasisId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductClassBasis', 'legalBasisId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductClassBasis', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductClassBasis', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,sortOrder: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProductClassBasis', 'sortOrder'), 
				                    validation: { required: true } }			
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
