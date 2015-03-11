define([
	'base/base-collection',
	'models/CommonMasterData/System/InsVatType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsVatTypes',
		model: Model
	});

	return collection;
});
