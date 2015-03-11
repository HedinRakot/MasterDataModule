define([
	'base/base-object-filter-view',
	'models/CommonMasterData/System/FilterSysLanguage'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
