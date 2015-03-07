define([
	'base/base-collection',
	'models/CommonMasterData/Org/OrganizationalUnits/OrganizationalUnit'
], function (BaseCollection, Model) {
    'use strict';

    var collection = BaseCollection.extend({
        url: 'api/OrgOrganizationalUnit',
        model: Model
    });

    return collection;
});