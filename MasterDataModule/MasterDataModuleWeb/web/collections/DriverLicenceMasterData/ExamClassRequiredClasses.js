define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamClassRequiredClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamClassRequiredClasses',
		model: Model
	});

	return collection;
});
