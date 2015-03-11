define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsOpticalDefect'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsOpticalDefects',
		model: Model
	});

	return collection;
});
