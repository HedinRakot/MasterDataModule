define([
	'base/base-object-filter-view',
	'models/Settings/FilterSiteInfosWithLastResult'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
