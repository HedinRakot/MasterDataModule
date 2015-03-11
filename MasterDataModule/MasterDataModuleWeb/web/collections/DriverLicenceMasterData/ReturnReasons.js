define([
	'base/base-collection',
	'models/DriverLicenceMasterData/ReturnReason'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ReturnReasons',
		model: Model
	});

	return collection;
});
