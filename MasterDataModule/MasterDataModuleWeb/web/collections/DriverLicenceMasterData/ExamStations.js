define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ExamStation'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExamStations',
		model: Model
	});

	return collection;
});
