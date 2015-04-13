define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataSiteInfos',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataSiteInfo', 'name'), 
				                    validation: { required: true } }			
			,timeoutChecking: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataSiteInfo', 'timeoutChecking'), 
				                    validation: { required: false } }			
			,sitePath: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataSiteInfo', 'sitePath'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataSiteInfo', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('MasterDataSiteInfo', 'toDate'), 
				                    validation: { required: true, date: true } }			
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
