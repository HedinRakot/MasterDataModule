define([
	'base/base-collection',
	'models/CommonMasterData/System/ExpPassengersType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/ExpPassengersTypes',
		model: Model
	});

	return collection;
});
