define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpOrgAssociationTypes',
		fields: {
			id: { type: "number", editable: false }
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empOrgAssociationType', 'name'), 
				                    validation: { required: true, maxLength: 10 } }			
			,description: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empOrgAssociationType', 'description'), 
				                    validation: { required: false, maxLength: 50 } }			
		}
	});
	return model;
});
