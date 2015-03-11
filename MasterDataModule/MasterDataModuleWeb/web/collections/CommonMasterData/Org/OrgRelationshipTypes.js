define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgRelationshipType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgRelationshipTypes',
		model: Model
	});

	return collection;
});
