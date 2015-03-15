define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgCostCenterResponsibleEmployeeRsp'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgCostCenterResponsibleEmployeeRsps',
		model: Model
	});

	return collection;
});
