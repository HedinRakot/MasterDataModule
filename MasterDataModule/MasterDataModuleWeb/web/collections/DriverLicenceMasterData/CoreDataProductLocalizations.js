define([
	'base/base-collection',
	'models/DriverLicenceMasterData/CoreDataProducts/CoreDataProductLocalization'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/CoreDataProductLocalizations',
		model: Model
	});

	return collection;
});