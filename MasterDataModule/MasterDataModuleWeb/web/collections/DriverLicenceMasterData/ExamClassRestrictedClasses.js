define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamClassRestrictedClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamClassRestrictedClasses',
		model: Model
	});

	return collection;
});
