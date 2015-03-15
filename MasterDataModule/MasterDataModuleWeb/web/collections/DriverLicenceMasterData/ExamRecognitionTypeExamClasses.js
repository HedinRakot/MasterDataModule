define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamRecognitionTypeExamClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamRecognitionTypeExamClasses',
		model: Model
	});

	return collection;
});
