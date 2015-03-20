define([
	'base/base-collection',
	'models/DriverLicenceMasterData/CommunityParticipant'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/CommunityParticipants',
		model: Model
	});

	return collection;
});
