define([
	'base/base-collection',
	'models/CommonMasterData/Product/InsCoreDataProduct'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsCoreDataProducts',
		model: Model
	});

	return collection;
});
