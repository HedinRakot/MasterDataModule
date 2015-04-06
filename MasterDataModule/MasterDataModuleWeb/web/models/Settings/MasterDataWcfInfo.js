define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataWcfInfos',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataWcfInfo', 'name'), 
				                    validation: { required: false, maxLength: 0 } }			
			,wsdlPath: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataWcfInfo', 'wsdlPath'), 
				                    validation: { required: false, maxLength: 0 } }			
			,timeoutChecking: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataWcfInfo', 'timeoutChecking'), 
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
