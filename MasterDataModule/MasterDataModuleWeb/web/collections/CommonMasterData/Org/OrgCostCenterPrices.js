define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgCostCenterPrice'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgCostCenterPrices',
		model: Model
	});

	return collection;
});
