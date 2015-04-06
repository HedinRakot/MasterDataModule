define([
	'base/base-collection',
	'models/Settings/MasterDataMonitorState'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/MasterDataMonitorStates',
		model: Model
	});

	return collection;
});
