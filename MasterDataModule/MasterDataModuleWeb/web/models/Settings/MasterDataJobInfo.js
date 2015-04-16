define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataJobInfos',
		fields: {
			id: { type: "number", editable: false }
			,connectionString: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'connectionString'), 
				                    validation: { required: true } }			
			,tableName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'tableName'), 
				                    validation: { required: true } }			
			,timeoutChecking: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'timeoutChecking'), 
				                    validation: { required: true } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'name'), 
				                    validation: { required: true } }			
			,jobName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'jobName'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,logTypeInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'logTypeInfoId'), 
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
