define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgAccountType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgAccountTypes',
		model: Model
	});

	return collection;
});
