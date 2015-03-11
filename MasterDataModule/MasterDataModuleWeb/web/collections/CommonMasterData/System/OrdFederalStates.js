define([
	'base/base-collection',
	'models/CommonMasterData/System/OrdFederalState'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdFederalStates',
		model: Model
	});

	return collection;
});
