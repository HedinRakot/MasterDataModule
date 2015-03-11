define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrdCustomerInfos',
		fields: {
			id: { type: "number", editable: false }
			,textValue: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ordCustomerInfo', 'textValue'), 
				                    validation: { required: true, maxLength: 512 } }			
			,numberValue: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ordCustomerInfo', 'numberValue'), 
				                    validation: { required: false } }			
			,infoType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ordCustomerInfo', 'infoType'), 
				                    validation: { required: false } }			
		}
	});
	return model;
});
