define([
	'base/base-collection',
	'models/CommonMasterData/Product/InsProductObjectType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsProductObjectTypes',
		model: Model
	});

	return collection;
});
