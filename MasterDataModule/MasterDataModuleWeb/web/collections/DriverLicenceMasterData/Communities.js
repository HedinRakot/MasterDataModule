define([
	'base/base-collection',
	'models/DriverLicenceMasterData/Community'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/Communities',
		model: Model
	});

	return collection;
});
