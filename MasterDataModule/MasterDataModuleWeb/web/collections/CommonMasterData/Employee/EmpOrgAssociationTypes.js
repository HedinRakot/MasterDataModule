define([
	'base/base-collection',
	'models/CommonMasterData/Employee/EmpOrgAssociationType'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/EmpOrgAssociationTypes',
		model: Model
	});

	return collection;
});
