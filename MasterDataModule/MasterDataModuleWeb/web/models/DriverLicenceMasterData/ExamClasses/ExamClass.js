﻿define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamClasses',
		fields: {
			id: { type: "number", editable: false },
			name: { type: "string", editable: Application.canTableItemBeEdit('examClass', 'name'), validation: { required: true, maxLength: 10 } },
			description: { type: "string", editable: Application.canTableItemBeEdit('examClass', 'description'), validation: { required: true, maxLength: 250 } },
			fromDate: { type: "date", editable: Application.canTableItemBeEdit('examClass', 'fromDate'), validation: { required: true, date: true } },
			toDate: { type: "date", editable: Application.canTableItemBeEdit('examClass', 'toDate'), validation: { required: true, date: true } },
			isFsClass: { type: "boolean", editable: Application.canTableItemBeEdit('examClass', 'isFsClass') },
			isMofa: { type: "boolean", editable: Application.canTableItemBeEdit('examClass', 'isMofa') },
			sortOrder: { type: "number", editable: Application.canTableItemBeEdit('examClass', 'sortOrder'), validation: { required: true, integer: true } },
		}
	});

	return model;
});