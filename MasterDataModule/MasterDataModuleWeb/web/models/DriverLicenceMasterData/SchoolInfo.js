define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/SchoolInfos',
		fields: {
			id: { type: "number", editable: false }
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('SchoolInfo', 'description'), 
				                    validation: { required: true, maxLength: 250 } }			
			,text: { type: "string", 
			                        editable: Application.canTableItemBeEdit('SchoolInfo', 'text'), 
				                    validation: { required: true, maxLength: 250 } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('SchoolInfo', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('SchoolInfo', 'toDate'), 
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
