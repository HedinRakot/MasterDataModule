define([
	'base/base-collection',
	'models/CommonMasterData/System/SysLocation'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SysLocations',
		model: Model
	});

	return collection;
});
