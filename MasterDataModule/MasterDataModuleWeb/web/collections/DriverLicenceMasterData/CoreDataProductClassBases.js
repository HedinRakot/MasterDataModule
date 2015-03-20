define([
	'base/base-collection',
	'models/DriverLicenceMasterData/CoreDataProductClassBasis'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/CoreDataProductClassBases',
		model: Model
	});

	return collection;
});
