define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/LegalBasises',
		fields: {
			id: { type: "number", editable: false },
			name: { type: "string", editable: Application.canTableItemBeEdit('legalBasis', 'name'), validation: { required: true, maxLength: 50 } },
			description: { type: "string", editable: Application.canTableItemBeEdit('legalBasis', 'description'), validation: { required: true, maxLength: 250 } },
			fromDate: { type: "date", editable: Application.canTableItemBeEdit('legalBasis', 'fromDate'), validation: { required: true, date: true } },
			toDate: { type: "date", editable: Application.canTableItemBeEdit('legalBasis', 'toDate'), validation: { required: true, date: true } },
			isAttestationRequired: { type: "boolean", editable: Application.canTableItemBeEdit('legalBasis', 'isAttestationRequired') },
			messageReason: { type: "string", editable: Application.canTableItemBeEdit('legalBasis', 'messageReason'), validation: { required: true, maxLength: 50 } },
			messageReasonStyle: { type: "string", editable: Application.canTableItemBeEdit('legalBasis', 'messageReasonStyle'), validation: { required: true, maxLength: 50 } },
			printName: { type: "string", editable: Application.canTableItemBeEdit('legalBasis', 'printName'), validation: { required: true, maxLength: 50 } },
			replacementId: { type: "number", editable: Application.canTableItemBeEdit('legalBasis', 'replacementId'), validation: { integer: true } },
			isFirstAssignation: { type: "number", editable: Application.canTableItemBeEdit('legalBasis', 'isFirstAssignation'), validation: { required: true, integer: true } },
		}
	});

	return model;
});