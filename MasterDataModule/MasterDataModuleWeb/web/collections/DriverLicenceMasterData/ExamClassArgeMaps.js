define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamClassArgeMap'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamClassArgeMaps',
		model: Model
	});

	return collection;
});
