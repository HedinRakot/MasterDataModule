define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/CoreDataProducts',
		fields: {
			id: { type: "number", editable: false },
			name: { type: "string", editable: Application.canTableItemBeEdit('coreDataProduct', 'name'), validation: { required: true, maxLength: 250 } },
			description: { type: "string", editable: Application.canTableItemBeEdit('coreDataProduct', 'description'), validation: { required: true, maxLength: 250 } },
			fromDate: { type: "date", editable: Application.canTableItemBeEdit('coreDataProduct', 'fromDate'), validation: { required: true, date: true } },
			toDate: { type: "date", editable: Application.canTableItemBeEdit('coreDataProduct', 'toDate'), validation: { required: true, date: true } },

			minAge: { type: "number", editable: Application.canTableItemBeEdit('coreDataProduct', 'minAge'), validation: { required: true, integer: true } },
			maxAge: { type: "number", editable: Application.canTableItemBeEdit('coreDataProduct', 'maxAge'), validation: { required: false, integer: true } },
			examType: { type: "boolean", editable: Application.canTableItemBeEdit('coreDataProduct', 'examType'), validation: { required: true } },
			insCoreDataProductId: { type: "number", validation: { required: true } },
			insCoreDataProductName: { type: "string" },

			priorTimeInMonths: { type: "number", editable: Application.canTableItemBeEdit('coreDataProduct', 'priorTimeInMonths'), validation: { required: true, integer: true } },
			repeatTimeInDays: { type: "number", editable: Application.canTableItemBeEdit('coreDataProduct', 'repeatTimeInDays'), validation: { required: true, integer: true } },
			repeatTimeInDaysReduced: { type: "number", editable: Application.canTableItemBeEdit('coreDataProduct', 'repeatTimeInDaysReduced'), validation: { required: true, integer: true } },
			trainingCertFlag: { type: "boolean", editable: Application.canTableItemBeEdit('coreDataProduct', 'trainingCertFlag') },
			resultFlag: { type: "boolean", editable: Application.canTableItemBeEdit('coreDataProduct', 'resultFlag') },
			multiplyFlag: { type: "boolean", editable: Application.canTableItemBeEdit('coreDataProduct', 'multiplyFlag') },
			isMofaPrint: { type: "boolean", editable: Application.canTableItemBeEdit('coreDataProduct', 'isMofaPrint') },
			isAdditionalProduct: { type: "boolean", editable: Application.canTableItemBeEdit('coreDataProduct', 'isAdditionalProduct') },
			isPrepaymentRequired: { type: "boolean", editable: Application.canTableItemBeEdit('coreDataProduct', 'isPrepaymentRequired') },
			isMandatory: { type: "boolean", editable: Application.canTableItemBeEdit('coreDataProduct', 'isMandatory') },
		}
	});

	return model;
});