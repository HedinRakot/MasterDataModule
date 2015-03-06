define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpEmployees',
		fields: {
			id: { type: "number", editable: false },
			name: { type: "string", editable: Application.canTableItemBeEdit('empEmployee', 'name'), validation: { required: true, maxLength: 90 } },
			lastName: { type: "string", editable: Application.canTableItemBeEdit('empEmployee', 'lastName'), validation: { required: true, maxLength: 90 } },
			fromDate: { type: "date", editable: Application.canTableItemBeEdit('insCoreDataProduct', 'fromDate'), validation: { required: true, date: true } },
			toDate: { type: "date", editable: Application.canTableItemBeEdit('insCoreDataProduct', 'toDate'), validation: { required: true, date: true } },
			middleName: { type: "string", editable: Application.canTableItemBeEdit('empEmployee', 'middleName'), validation: { required: true, maxLength: 90 } },
			personalNumber: { type: "string", editable: Application.canTableItemBeEdit('empEmployee', 'personalNumber'), validation: { required: true, maxLength: 10 } },
		}
	});

	return model;
});