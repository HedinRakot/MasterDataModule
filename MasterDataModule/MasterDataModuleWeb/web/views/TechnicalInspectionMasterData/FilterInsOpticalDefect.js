define([
	'base/base-object-filter-view',
	'models/TechnicalInspectionMasterData/FilterInsOpticalDefect'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
