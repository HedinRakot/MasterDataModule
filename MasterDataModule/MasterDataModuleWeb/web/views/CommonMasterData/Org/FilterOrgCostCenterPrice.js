define([
	'base/base-object-filter-view',
	'models/CommonMasterData/Org/FilterOrgCostCenterPrice'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
