define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamConstraint'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamConstraints',
		model: Model
	});

	return collection;
});
