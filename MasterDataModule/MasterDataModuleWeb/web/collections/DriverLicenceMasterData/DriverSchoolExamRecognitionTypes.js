define([
	'base/base-collection',
	'models/DriverLicenceMasterData/DriverSchoolExamRecognitionType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/DriverSchoolExamRecognitionTypes',
		model: Model
	});

	return collection;
});
