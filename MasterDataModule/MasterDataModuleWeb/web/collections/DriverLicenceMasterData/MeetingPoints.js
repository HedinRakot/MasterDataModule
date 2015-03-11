define([
	'base/base-collection',
	'models/DriverLicenceMasterData/MeetingPoint'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MeetingPoints',
		model: Model
	});

	return collection;
});
