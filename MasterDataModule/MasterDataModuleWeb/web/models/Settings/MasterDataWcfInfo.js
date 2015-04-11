define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataWcfInfos',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataWcfInfo', 'name'), 
				                    validation: { required: false } }			
			,wsdlPath: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataWcfInfo', 'wsdlPath'), 
				                    validation: { required: false } }			
			,timeoutChecking: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataWcfInfo', 'timeoutChecking'), 
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
