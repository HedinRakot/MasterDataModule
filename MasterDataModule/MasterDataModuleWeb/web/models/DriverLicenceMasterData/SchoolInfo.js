define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SchoolInfos',
		fields: {
			id: { type: "number", editable: false }
			,text: { type: "string", 
			                        editable: Application.canTableItemBeEdit('schoolInfo', 'text'), 
				                    validation: { required: false, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('schoolInfo', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('schoolInfo', 'toDate'), 
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
