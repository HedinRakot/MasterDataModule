define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataJobCheckResults',
		fields: {
			id: { type: "number", editable: false }
			,lastRunTime: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobCheckResults', 'lastRunTime'), 
				                    validation: { required: false, date: true } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobCheckResults', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobCheckResults', 'checkStatus'), 
				                    validation: { required: false } }			
			,masterDataJobInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataJobCheckResults', 'masterDataJobInfoId'), 
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
