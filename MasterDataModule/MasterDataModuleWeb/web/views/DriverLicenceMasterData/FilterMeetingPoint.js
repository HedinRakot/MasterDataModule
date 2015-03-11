define([
	'base/base-object-filter-view',
	'models/DriverLicenceMasterData/FilterMeetingPoint'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
