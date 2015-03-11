define([
	'base/base-collection',
	'models/CommonMasterData/Employee/EmpEmployee'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/EmpEmployees',
		model: Model
	});

	return collection;
});
