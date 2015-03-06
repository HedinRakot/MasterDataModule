define([
	'base/base-collection',
	'models/DriverLicenceMasterData/CoreDataProducts/InsCoreDataProduct'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsCoreDataProducts',
		model: Model
	});

	return collection;
});