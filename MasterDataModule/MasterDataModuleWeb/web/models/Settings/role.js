define(function () {
	'use strict';

	var model = Backbone.Model.extend({
		fields: {
			id: { type: "number", editable: false },
			name: { type: "string", editable: true, validation: { required: true } },
			permissions: { }
		}
	});

	return model;
});