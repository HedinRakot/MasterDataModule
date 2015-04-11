define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataJobInfos',
		fields: {
			id: { type: "number", editable: false }
			,connectionString: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'connectionString'), 
				                    validation: { required: false } }			
			,tableName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'tableName'), 
				                    validation: { required: false } }			
			,timeoutChecking: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'timeoutChecking'), 
				                    validation: { required: false } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'name'), 
				                    validation: { required: false } }			
			,jobName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobInfo', 'jobName'), 
				                    validation: { required: false } }			
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
