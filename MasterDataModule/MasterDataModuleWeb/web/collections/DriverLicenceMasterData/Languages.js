define([
	'base/base-collection',
	'models/DriverLicenceMasterData/Language'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/Languages',
		model: Model
	});

	return collection;
});
