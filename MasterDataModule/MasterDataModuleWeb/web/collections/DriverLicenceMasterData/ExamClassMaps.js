define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamClassMap'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamClassMaps',
		model: Model
	});

	return collection;
});
