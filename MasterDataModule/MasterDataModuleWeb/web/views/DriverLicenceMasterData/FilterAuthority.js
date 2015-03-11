define([
	'base/base-object-filter-view',
	'models/DriverLicenceMasterData/FilterAuthority'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
