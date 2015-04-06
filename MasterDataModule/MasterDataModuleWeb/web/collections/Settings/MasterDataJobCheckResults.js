define([
	'base/base-collection',
	'models/Settings/MasterDataJobCheckResults'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataJobCheckResults',
		model: Model
	});

	return collection;
});
