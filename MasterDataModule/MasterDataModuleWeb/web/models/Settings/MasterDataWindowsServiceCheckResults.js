define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataWindowsServiceCheckResults',
		fields: {
			id: { type: "number", editable: false }
			,checkStatus: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataWindowsServiceCheckResults', 'checkStatus'), 
				                    validation: { required: false } }			
			,checkDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataWindowsServiceCheckResults', 'checkDate'), 
				                    validation: { required: false, date: true } }			
			,message: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataWindowsServiceCheckResults', 'message'), 
				                    validation: { required: false } }			
			,attempt: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataWindowsServiceCheckResults', 'attempt'), 
				                    validation: { required: false } }			
			,masterDataWindowsServiceInfoId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataWindowsServiceCheckResults', 'masterDataWindowsServiceInfoId'), 
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
