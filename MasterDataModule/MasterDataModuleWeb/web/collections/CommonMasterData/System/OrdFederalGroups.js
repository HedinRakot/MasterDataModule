define([
	'base/base-collection',
	'models/CommonMasterData/System/OrdFederalGroup'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdFederalGroups',
		model: Model
	});

	return collection;
});
