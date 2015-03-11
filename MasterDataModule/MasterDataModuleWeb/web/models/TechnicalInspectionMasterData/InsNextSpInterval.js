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
		}
	});
	return model;
});
