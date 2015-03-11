define([
	'base/base-collection',
	'models/CommonMasterData/System/SysCountry'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SysCountries',
		model: Model
	});

	return collection;
});
