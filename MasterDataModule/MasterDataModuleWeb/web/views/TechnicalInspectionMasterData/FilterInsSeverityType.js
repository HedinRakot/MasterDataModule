define([
	'base/base-object-filter-view',
	'models/TechnicalInspectionMasterData/FilterInsSeverityType'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
