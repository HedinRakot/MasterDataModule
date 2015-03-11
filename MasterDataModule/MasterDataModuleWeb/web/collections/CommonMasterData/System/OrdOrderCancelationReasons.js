define([
	'base/base-collection',
	'models/CommonMasterData/System/OrdOrderCancelationReason'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdOrderCancelationReasons',
		model: Model
	});

	return collection;
});
