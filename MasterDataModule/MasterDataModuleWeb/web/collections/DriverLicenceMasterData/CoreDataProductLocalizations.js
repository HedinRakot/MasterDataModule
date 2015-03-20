define([
	'base/base-collection',
	'models/DriverLicenceMasterData/CoreDataProductLocalization'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/CoreDataProductLocalizations',
		model: Model
	});

	return collection;
});
