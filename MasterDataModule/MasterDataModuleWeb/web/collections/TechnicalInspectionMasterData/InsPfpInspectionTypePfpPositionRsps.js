define([
	'base/base-collection',
	'models/TechnicalInspectionMasterData/InsPfpInspectionTypePfpPositionRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/InsPfpInspectionTypePfpPositionRsps',
		model: Model
	});

	return collection;
});
