define([
	'base/base-collection',
	'models/DriverLicenceMasterData/LegalBasises/LegalBasis'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/LegalBasises',
		model: Model
	});

	return collection;
});