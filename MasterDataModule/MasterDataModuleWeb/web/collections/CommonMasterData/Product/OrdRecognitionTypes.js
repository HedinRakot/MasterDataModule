define([
	'base/base-collection',
	'models/CommonMasterData/Product/OrdRecognitionType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdRecognitionTypes',
		model: Model
	});

	return collection;
});
