define([
	'base/base-object-filter-view',
	'models/TechnicalInspectionMasterData/FilterInsInspectionStep'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});