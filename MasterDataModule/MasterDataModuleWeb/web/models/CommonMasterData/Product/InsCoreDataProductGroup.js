define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsCoreDataProductGroups',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProductGroup', 'name'), 
				                    validation: { required: true, maxLength: 250 } }			
			,defaultDuration: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insCoreDataProductGroup', 'defaultDuration'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
