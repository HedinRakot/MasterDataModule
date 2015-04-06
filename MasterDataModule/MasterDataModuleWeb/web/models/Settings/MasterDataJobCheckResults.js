define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataJobCheckResults',
		fields: {
			id: { type: "number", editable: false }
			,lastRunTime: { type: "date", 
			                        editable: Application.canTableItemBeEdit('masterDataJobCheckResults', 'lastRunTime'), 
				                    validation: { required: false, date: true } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('masterDataJobCheckResults', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataJobCheckResults', 'checkStatus'), 
				                    validation: { required: false } }			
			,masterDataJobInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataJobCheckResults', 'masterDataJobInfoId'), 
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
