define([
	'base/base-object-filter-view',
	'models/Settings/FilterMasterDataWcfCheckResults'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
