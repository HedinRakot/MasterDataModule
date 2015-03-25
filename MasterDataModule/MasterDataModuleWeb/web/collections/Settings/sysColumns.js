define([
	'base/base-collection',
	'models/Settings/SysColumn'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SysColumns',
		model: Model
	});

	return collection;
});
