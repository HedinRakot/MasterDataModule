define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataMonitorStates',
		fields: {
			id: { type: "number", editable: false }
			,reconfigure: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('MasterDataMonitorState', 'reconfigure'), 
				                    validation: { required: false } }			
			,reconfigureCheckingTimeout: { type: "number", 
			                        editable: Application.canTableItemBeEdit('MasterDataMonitorState', 'reconfigureCheckingTimeout'), 
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
