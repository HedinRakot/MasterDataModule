define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ArgeVersion'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ArgeVersions',
		model: Model
	});

	return collection;
});
