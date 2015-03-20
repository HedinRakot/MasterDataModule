define([
	'base/base-collection',
	'models/DriverLicenceMasterData/DriverSchool'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/DriverSchools',
		model: Model
	});

	return collection;
});
