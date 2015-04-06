define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataJobInfos',
		fields: {
			id: { type: "number", editable: false }
			,connectionString: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataJobInfo', 'connectionString'), 
				                    validation: { required: false, maxLength: 0 } }			
			,tableName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataJobInfo', 'tableName'), 
				                    validation: { required: false, maxLength: 0 } }			
			,timeoutChecking: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataJobInfo', 'timeoutChecking'), 
				                    validation: { required: false } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataJobInfo', 'name'), 
				                    validation: { required: false, maxLength: 0 } }			
			,jobName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataJobInfo', 'jobName'), 
				                    validation: { required: false, maxLength: 0 } }			
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
