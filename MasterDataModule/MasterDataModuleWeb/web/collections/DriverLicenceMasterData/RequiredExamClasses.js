define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamClasses/RequiredExamClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
		url: 'api/RequiredExamClasses',
		model: Model
	});

	return collection;
});