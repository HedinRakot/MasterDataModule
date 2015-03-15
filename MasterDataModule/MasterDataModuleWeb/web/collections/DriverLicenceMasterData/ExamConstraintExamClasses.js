define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamConstraintExamClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamConstraintExamClasses',
		model: Model
	});

	return collection;
});
