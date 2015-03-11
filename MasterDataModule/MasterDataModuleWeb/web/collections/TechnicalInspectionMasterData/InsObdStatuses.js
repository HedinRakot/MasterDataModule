define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsObdStatus'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsObdStatuses',
		model: Model
	});

	return collection;
});
