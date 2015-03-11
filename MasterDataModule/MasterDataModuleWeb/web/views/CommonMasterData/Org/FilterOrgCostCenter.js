define([
	'base/base-object-filter-view',
	'models/CommonMasterData/Org/FilterOrgCostCenter'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
