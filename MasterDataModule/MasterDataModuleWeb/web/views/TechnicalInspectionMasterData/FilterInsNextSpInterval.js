define([
	'base/base-object-filter-view',
	'models/TechnicalInspectionMasterData/FilterInsNextSpInterval'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
