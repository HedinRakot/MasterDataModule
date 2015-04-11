define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataWcfCheckResults',
		fields: {
			id: { type: "number", editable: false }
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataWcfCheckResults', 'checkStatus'), 
				                    validation: { required: false } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataWcfCheckResults', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataWcfCheckResults', 'message'), 
				                    validation: { required: false } }			
			,attempt: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataWcfCheckResults', 'attempt'), 
				                    validation: { required: false } }			
			,masterDataWcfInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataWcfCheckResults', 'masterDataWcfInfoId'), 
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
