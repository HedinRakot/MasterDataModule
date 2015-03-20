define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrgOrganizationalUnit'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/OrgOrganizationalUnits',
		model: Model
	});

	return collection;
});
