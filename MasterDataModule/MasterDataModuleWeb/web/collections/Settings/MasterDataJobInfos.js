define([
	'base/base-collection',
	'models/Settings/MasterDataJobInfo'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataJobInfos',
		model: Model
	});

	return collection;
});
