define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsNextSpIntervals',
		fields: {
			id: { type: "number", editable: false }
			,insProductObjectTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insNextSpInterval', 'insProductObjectTypeId'), 
				                    validation: { required: true } }			
			,insProductObjectClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insNextSpInterval', 'insProductObjectClassId'), 
				                    validation: { required: true } }			
			,ageMonthFrom: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insNextSpInterval', 'ageMonthFrom'), 
				                    validation: { required: false } }			
			,ageMonthTo: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insNextSpInterval', 'ageMonthTo'), 
				                    validation: { required: false } }			
			,spInterval: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insNextSpInterval', 'spInterval'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insNextSpInterval', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insNextSpInterval', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
