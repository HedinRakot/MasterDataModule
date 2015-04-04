define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataSiteInfos',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataSiteInfo', 'name'), 
				                    validation: { required: true, maxLength: 0 } }			
			,timeoutChecking: { type: "number", 
			                        editable: Application.canTableItemBeEdit('masterDataSiteInfo', 'timeoutChecking'), 
				                    validation: { required: false } }			
			,sitePath: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataSiteInfo', 'sitePath'), 
				                    validation: { required: true, maxLength: 0 } }			
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
