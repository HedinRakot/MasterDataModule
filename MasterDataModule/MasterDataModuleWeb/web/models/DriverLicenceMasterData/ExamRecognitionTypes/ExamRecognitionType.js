define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamRecognitionTypes',
		fields: {
			id: { type: "number", editable: false },
			name: { type: "string", editable: Application.canTableItemBeEdit('legalBasis', 'name'), validation: { required: true, maxLength: 50 } },
			description: { type: "string", editable: Application.canTableItemBeEdit('legalBasis', 'description'), validation: { required: true, maxLength: 250 } },
			fromDate: { type: "date", editable: Application.canTableItemBeEdit('legalBasis', 'fromDate'), validation: { required: true, date: true } },
			toDate: { type: "date", editable: Application.canTableItemBeEdit('legalBasis', 'toDate'), validation: { required: true, date: true } },
		}
	});

	return model;
});