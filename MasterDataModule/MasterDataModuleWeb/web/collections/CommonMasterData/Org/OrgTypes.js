define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgTypes',
		model: Model
	});

	return collection;
});
