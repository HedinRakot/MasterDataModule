define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsNextSpIntervals',
		fields: {
			id: { type: "number", editable: false }
			,insProductObjectTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsNextSpInterval', 'insProductObjectTypeId'), 
				                    validation: { required: true } }			
			,insProductObjectClassId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsNextSpInterval', 'insProductObjectClassId'), 
				                    validation: { required: true } }			
			,ageMonthFrom: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsNextSpInterval', 'ageMonthFrom'), 
				                    validation: { required: false } }			
			,ageMonthTo: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsNextSpInterval', 'ageMonthTo'), 
				                    validation: { required: false } }			
			,spInterval: { type: "number", 
			                        editable: Application.canTableItemBeEdit('InsNextSpInterval', 'spInterval'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsNextSpInterval', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsNextSpInterval', 'toDate'), 
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
