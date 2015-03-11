define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgCostCenter'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgCostCenters',
		model: Model
	});

	return collection;
});
