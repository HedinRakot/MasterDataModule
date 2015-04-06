define([
	'base/base-object-filter-view',
	'models/Settings/FilterMasterDataSubscribers'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
