define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/GetJobsStatuses',
		fields: {
			id: { type: "number", editable: false }
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetJobsStatus', 'checkStatus'), 
				                    validation: { required: false } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('GetJobsStatus', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,lastRunTime: { type: "date", 
			                        editable: Application.canTableItemBeEdit('GetJobsStatus', 'lastRunTime'), 
				                    validation: { required: false, date: true } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetJobsStatus', 'name'), 
				                    validation: { required: true } }			
			,jobName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('GetJobsStatus', 'jobName'), 
				                    validation: { required: true } }			
			,logTypeInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('GetJobsStatus', 'logTypeInfoId'), 
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
