define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamRoom'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamRooms',
		model: Model
	});

	return collection;
});
