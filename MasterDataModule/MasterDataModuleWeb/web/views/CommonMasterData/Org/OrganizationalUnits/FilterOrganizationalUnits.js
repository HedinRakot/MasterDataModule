define([
	'base/base-object-filter-view',
	'models/CommonMasterData/Org/OrganizationalUnits/FilterOrgOrganizationalUnit'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});