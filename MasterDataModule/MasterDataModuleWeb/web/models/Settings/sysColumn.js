define(function () {
	'use strict';

	var model = Backbone.Model.extend({
		fields: {
		    id: { type: "number", editable: false },
		    tableId: { type: "number", editable: false },
			description: { type: "string", editable: false },
			readOnly: { type: "boolean", editable: true },
		}
	});

	return model;
});