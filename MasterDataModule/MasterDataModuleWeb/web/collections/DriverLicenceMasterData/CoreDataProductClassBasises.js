define([
	'base/base-collection',
	'models/DriverLicenceMasterData/CoreDataProducts/CoreDataProductClassBasis'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/CoreDataProductClassBasises',
		model: Model
	});

	return collection;
});