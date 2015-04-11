define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ApplicationLogs',
		fields: {
			id: { type: "number", editable: false }
			,logType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ApplicationLogs', 'logType'), 
				                    validation: { required: true } }			
			,logLevel: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ApplicationLogs', 'logLevel'), 
				                    validation: { required: true } }			
			,date: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ApplicationLogs', 'date'), 
				                    validation: { required: true, date: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ApplicationLogs', 'message'), 
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
