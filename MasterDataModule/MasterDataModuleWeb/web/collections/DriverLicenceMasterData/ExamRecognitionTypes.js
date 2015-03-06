define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamRecognitionTypes/ExamRecognitionType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamRecognitionTypes',
		model: Model
	});

	return collection;
});