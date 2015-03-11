define([
	'base/base-object-filter-view',
	'models/TechnicalInspectionMasterData/FilterInsAvailableInspectionStep'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
