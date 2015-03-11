define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamPossibleResult'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamPossibleResults',
		model: Model
	});

	return collection;
});
