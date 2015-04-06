define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataSiteCheckResults',
		fields: {
			id: { type: "number", editable: false }
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataSiteCheckResults', 'checkStatus'), 
				                    validation: { required: false } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('masterDataSiteCheckResults', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataSiteCheckResults', 'message'), 
				                    validation: { required: false, maxLength: 0 } }			
			,attempt: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataSiteCheckResults', 'attempt'), 
				                    validation: { required: false } }			
			,masterDataSiteInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataSiteCheckResults', 'masterDataSiteInfoId'), 
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
