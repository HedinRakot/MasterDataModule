define([
	'base/base-collection',
	'models/DriverLicenceMasterData/SchoolInfo'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SchoolInfos',
		model: Model
	});

	return collection;
});
