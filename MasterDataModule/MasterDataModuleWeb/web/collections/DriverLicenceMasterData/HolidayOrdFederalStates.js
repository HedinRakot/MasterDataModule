define([
	'base/base-collection',
	'models/DriverLicenceMasterData/HolidayOrdFederalState'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/HolidayOrdFederalStates',
		model: Model
	});

	return collection;
});
