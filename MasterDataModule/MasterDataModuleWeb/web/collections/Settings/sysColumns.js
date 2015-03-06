define([
	'base/base-collection',
	'models/settings/sysColumn'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/sysColumns',
		model: Model
	});

	return collection;
});