define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamStationExamRecognitionType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamStationExamRecognitionTypes',
		model: Model
	});

	return collection;
});
