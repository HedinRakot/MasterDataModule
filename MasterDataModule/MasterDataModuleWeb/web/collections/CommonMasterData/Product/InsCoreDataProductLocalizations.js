define([
	'base/base-collection',
	'models/CommonMasterData/Product/InsCoreDataProductLocalization'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsCoreDataProductLocalizations',
		model: Model
	});

	return collection;
});
