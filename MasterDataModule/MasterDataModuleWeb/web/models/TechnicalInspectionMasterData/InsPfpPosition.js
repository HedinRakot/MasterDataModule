define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsPfpPositions',
		fields: {
			id: { type: "number", editable: false }
			,text: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insPfpPosition', 'text'), 
				                    validation: { required: true, maxLength: 250 } }			
			,topId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insPfpPosition', 'topId'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insPfpPosition', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insPfpPosition', 'toDate'), 
				                    validation: { required: true, date: true } }			
		}
	});
	return model;
});
