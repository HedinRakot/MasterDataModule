define([
	'base/base-collection',
	'models/CommonMasterData/Customer/OrdPartnerRole'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrdPartnerRoles',
		model: Model
	});

	return collection;
});
