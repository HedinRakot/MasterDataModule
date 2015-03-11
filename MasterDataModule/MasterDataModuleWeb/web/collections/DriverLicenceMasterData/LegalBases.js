define([
	'base/base-collection',
	'models/DriverLicenceMasterData/LegalBasis'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/LegalBases',
		model: Model
	});

	return collection;
});
