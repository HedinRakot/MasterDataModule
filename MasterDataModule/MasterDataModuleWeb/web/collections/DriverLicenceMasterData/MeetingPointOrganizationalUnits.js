define([
	'base/base-collection',
	'models/DriverLicenceMasterData/MeetingPointOrganizationalUnit'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MeetingPointOrganizationalUnits',
		model: Model
	});

	return collection;
});
