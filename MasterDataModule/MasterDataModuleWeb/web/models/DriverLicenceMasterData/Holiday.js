define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/Holidays',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('holiday', 'name'), 
				                    validation: { required: false, maxLength: 90 } }			
			,date: { type: "date", 
			                        editable: Application.canTableItemBeEdit('holiday', 'date'), 
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
