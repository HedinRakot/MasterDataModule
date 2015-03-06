define(function () {
	'use strict';

	var model = Backbone.Model.extend({
		fields: {
			id: { type: "number", editable: false },
			date: { type: "date", editable: false },
			description: { type: "string", editable: false },
			userLogin: { type: "string", editable: false }
		}
	});

	return model;
});