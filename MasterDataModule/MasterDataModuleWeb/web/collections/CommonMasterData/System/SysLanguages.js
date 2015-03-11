define([
	'base/base-collection',
	'models/CommonMasterData/System/SysLanguage'
], function (BaseCollection, Model) {
	'use strict';

	var collection = BaseCollection.extend({
	    url: 'api/SysLanguages',
		model: Model
	});

	return collection;
});
