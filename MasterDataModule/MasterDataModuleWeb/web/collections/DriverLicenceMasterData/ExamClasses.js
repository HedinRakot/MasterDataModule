define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamClasses/ExamClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamClasses',
		model: Model
	});

	return collection;
});