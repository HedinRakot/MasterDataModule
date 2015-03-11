define([
	'base/base-collection',
	'models/CommonMasterData/Product/InsProductObjectClass'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsProductObjectClasses',
		model: Model
	});

	return collection;
});
