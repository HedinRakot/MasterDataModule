define(function () {
	'use strict';

	var model = Backbone.Model.extend({
		fields: {
			id: { type: "number", editable: false },
			login: { type: "string", validation: { required: true } },
			passwordConfirmation: { type: "string", editable: false, validation: { required: true } },
			password: { type: "string", editable: false, validation: { required: true } },
			name: { type: "string", editable: true, validation: { required: true } },
			shortName: { type: "string", editable: true, validation: { required: true } },
			role: { type: "number", editable: true, validation: { required: true } },
		}
	});

	return model;
});