define([
	'base/base-object-filter-view',
	'models/TechnicalInspectionMasterData/FilterInsUnitCode'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
