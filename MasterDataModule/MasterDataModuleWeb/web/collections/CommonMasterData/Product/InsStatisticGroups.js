define([
	'base/base-collection',
	'models/CommonMasterData/Product/InsStatisticGroup'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsStatisticGroups',
		model: Model
	});

	return collection;
});
