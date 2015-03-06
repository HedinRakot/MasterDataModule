define(function () {
	'use strict';

	var model = Backbone.Model.extend({
		fields: {
		    id: { type: "number", editable: false },
			description: { type: "string", editable: false },
			editMode: { type: "number", editable: true },
		}
	});

	return model;
});