define([
	'base/base-object-filter-view',
	'models/Settings/FilterMasterDataNotifications'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
