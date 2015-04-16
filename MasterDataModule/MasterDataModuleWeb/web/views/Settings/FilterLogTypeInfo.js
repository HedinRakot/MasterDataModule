define([
	'base/base-object-filter-view',
	'models/Settings/FilterLogTypeInfo'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
