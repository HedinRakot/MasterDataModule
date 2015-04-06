define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataWcfCheckResults',
		fields: {
			id: { type: "number", editable: false }
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataWcfCheckResults', 'checkStatus'), 
				                    validation: { required: false } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('masterDataWcfCheckResults', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataWcfCheckResults', 'message'), 
				                    validation: { required: false, maxLength: 0 } }			
			,attempt: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataWcfCheckResults', 'attempt'), 
				                    validation: { required: false } }			
			,masterDataWcfInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataWcfCheckResults', 'masterDataWcfInfoId'), 
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
