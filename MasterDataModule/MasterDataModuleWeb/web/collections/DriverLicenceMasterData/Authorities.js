define([
	'base/base-collection',
	'models/DriverLicenceMasterData/Authority'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/Authorities',
		model: Model
	});

	return collection;
});
