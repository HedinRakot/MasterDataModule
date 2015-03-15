define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamClassInclusiveClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamClassInclusiveClasses',
		model: Model
	});

	return collection;
});
