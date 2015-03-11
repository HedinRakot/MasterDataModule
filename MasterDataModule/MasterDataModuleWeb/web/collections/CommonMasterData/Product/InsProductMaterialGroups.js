define([
	'base/base-collection',
	'models/CommonMasterData/Product/InsProductMaterialGroup'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsProductMaterialGroups',
		model: Model
	});

	return collection;
});
