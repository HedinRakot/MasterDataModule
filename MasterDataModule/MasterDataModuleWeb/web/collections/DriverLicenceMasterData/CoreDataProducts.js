define([
	'base/base-collection',
	'models/DriverLicenceMasterData/CoreDataProduct'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/CoreDataProducts',
		model: Model
	});

	return collection;
});
