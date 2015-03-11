define([
	'base/base-collection',
	'models/DriverLicenceMasterData/Holiday'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/Holidays',
		model: Model
	});

	return collection;
});
