define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/MasterDataSubscribers',
		fields: {
			id: { type: "number", editable: false }
			,email: { type: "string", 
			                        editable: Application.canTableItemBeEdit('masterDataSubscribers', 'email'), 
				                    validation: { required: false, maxLength: 0 } }			
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
