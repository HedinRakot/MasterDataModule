define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ArgeVersions',
		fields: {
			id: { type: "number", editable: false }
			,programmName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('argeVersion', 'programmName'), 
				                    validation: { required: true, maxLength: 30 } }			
			,versionSystem: { type: "string", 
			                        editable: Application.canTableItemBeEdit('argeVersion', 'versionSystem'), 
				                    validation: { required: true, maxLength: 10 } }			
			,expirationDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('argeVersion', 'expirationDate'), 
				                    validation: { required: false, date: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('argeVersion', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('argeVersion', 'toDate'), 
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
