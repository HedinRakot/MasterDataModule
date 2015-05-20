define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsObdStatuses',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsObdStatus', 'name'), 
				                    validation: { required: true, maxLength: 3 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsObdStatus', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
			,auView: { type: "string", 
			                        editable: Application.canTableItemBeEdit('InsObdStatus', 'auView'), 
				                    validation: { required: true, maxLength: 1 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsObdStatus', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('InsObdStatus', 'toDate'), 
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
