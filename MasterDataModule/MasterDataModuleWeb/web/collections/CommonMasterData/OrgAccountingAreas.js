define([
	'base/base-collection',
	'models/CommonMasterData/Org/AccountingAreas/AccountingArea'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/OrgAccountingArea',
        model: Model
    });

    return collection;
});
