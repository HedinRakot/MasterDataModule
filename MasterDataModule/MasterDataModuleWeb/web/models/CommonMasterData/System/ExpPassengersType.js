define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExpPassengersTypes',
		fields: {
			id: { type: "number", editable: false }
			,text: { type: "string", 
			                        editable: Application.canTableItemBeEdit('expPassengersType', 'text'), 
				                    validation: { required: true, maxLength: 100 } }			
			,code: { type: "string", 
			                        editable: Application.canTableItemBeEdit('expPassengersType', 'code'), 
				                    validation: { required: true, maxLength: 2 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('expPassengersType', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('expPassengersType', 'toDate'), 
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
