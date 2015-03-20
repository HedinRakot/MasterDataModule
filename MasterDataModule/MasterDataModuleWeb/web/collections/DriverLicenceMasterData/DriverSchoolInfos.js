define([
	'base/base-collection',
	'models/DriverLicenceMasterData/DriverSchoolInfo'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/DriverSchoolInfos',
		model: Model
	});

	return collection;
});
