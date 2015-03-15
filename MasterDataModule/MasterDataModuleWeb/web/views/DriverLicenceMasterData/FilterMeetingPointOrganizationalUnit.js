define([
	'base/base-object-filter-view',
	'models/DriverLicenceMasterData/FilterMeetingPointOrganizationalUnit'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
