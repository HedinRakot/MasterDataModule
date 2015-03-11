define([
	'base/base-collection',
	'models/CommonMasterData/System/SysPostCode'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SysPostCodes',
		model: Model
	});

	return collection;
});
