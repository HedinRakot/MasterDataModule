define([
	'base/base-collection',
	'models/CommonMasterData/Product/OrdRecognition'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdRecognitions',
		model: Model
	});

	return collection;
});
