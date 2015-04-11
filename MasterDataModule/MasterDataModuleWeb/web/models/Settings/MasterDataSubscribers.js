define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataSubscribers',
		fields: {
			id: { type: "number", editable: false }
			,email: { type: "string", 
			                        editable: Application.canTableItemBeEdit('MasterDataSubscribers', 'email'), 
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
