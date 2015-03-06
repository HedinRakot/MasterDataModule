define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamClasses/InclusiveExamClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
		url: 'api/InclusiveExamClasses',
		model: Model
	});

	return collection;
});