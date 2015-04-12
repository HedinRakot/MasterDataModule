define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataWindowsServiceInfos',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataWindowsServiceInfo', 'name'), 
				                    validation: { required: true } }			
			,machineName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataWindowsServiceInfo', 'machineName'), 
				                    validation: { required: true } }			
			,serviceName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataWindowsServiceInfo', 'serviceName'), 
				                    validation: { required: true } }			
			,timeoutChecking: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataWindowsServiceInfo', 'timeoutChecking'), 
				                    validation: { required: true } }			
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
