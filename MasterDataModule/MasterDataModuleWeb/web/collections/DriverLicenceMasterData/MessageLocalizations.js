define([
	'base/base-collection',
	'models/DriverLicenceMasterData/MessageLocalization'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MessageLocalizations',
		model: Model
	});

	return collection;
});
