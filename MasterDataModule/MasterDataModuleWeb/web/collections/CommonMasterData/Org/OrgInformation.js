define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgInformation'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgInformation',
		model: Model
	});

	return collection;
});
