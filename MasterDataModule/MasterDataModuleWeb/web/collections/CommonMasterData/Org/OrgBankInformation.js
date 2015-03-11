define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgBankInformation'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgBankInformation',
		model: Model
	});

	return collection;
});
