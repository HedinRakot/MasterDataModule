define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsCoreDataProducts',
		fields: {
			id: { type: "number", editable: false },
			name: { type: "string", editable: Application.canTableItemBeEdit('insCoreDataProduct', 'name'), validation: { required: true, maxLength: 250 } },
			description: { type: "string", editable: Application.canTableItemBeEdit('insCoreDataProduct', 'description'), validation: { required: true, maxLength: 250 } },
			productNumber: { type: "string", editable: Application.canTableItemBeEdit('insCoreDataProduct', 'productNumber'), validation: { required: true, maxLength: 50 } },
			fromDate: { type: "date", editable: Application.canTableItemBeEdit('insCoreDataProduct', 'fromDate'), validation: { required: true, date: true } },
			toDate: { type: "date", editable: Application.canTableItemBeEdit('insCoreDataProduct', 'toDate'), validation: { required: true, date: true } },
		}
	});

	return model;
});