define([
	'base/base-object-filter-view',
	'models/Settings/FilterMasterDataSiteCheckResults'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
