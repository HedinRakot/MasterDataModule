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
		}
	});
	return model;
});
