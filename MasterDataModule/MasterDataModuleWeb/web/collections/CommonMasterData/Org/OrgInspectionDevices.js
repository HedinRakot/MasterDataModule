define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgInspectionDevice'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgInspectionDevices',
		model: Model
	});

	return collection;
});
