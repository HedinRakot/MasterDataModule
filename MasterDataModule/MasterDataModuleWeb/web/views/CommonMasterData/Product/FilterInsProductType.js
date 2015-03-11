define([
	'base/base-object-filter-view',
	'models/CommonMasterData/Product/FilterInsProductType'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
