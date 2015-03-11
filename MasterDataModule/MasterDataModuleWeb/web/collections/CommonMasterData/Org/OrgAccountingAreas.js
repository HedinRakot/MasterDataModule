define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgAccountingArea'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgAccountingAreas',
		model: Model
	});

	return collection;
});
