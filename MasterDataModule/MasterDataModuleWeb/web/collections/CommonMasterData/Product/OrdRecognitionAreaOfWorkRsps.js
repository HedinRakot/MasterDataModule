define([
	'base/base-collection',
	'models/CommonMasterData/Product/OrdRecognitionAreaOfWorkRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdRecognitionAreaOfWorkRsps',
		model: Model
	});

	return collection;
});
