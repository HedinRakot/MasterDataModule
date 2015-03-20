define([
	'base/base-object-filter-view',
	'models/DriverLicenceMasterData/FilterCoreDataProduct'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
