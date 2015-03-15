define([
	'base/base-object-filter-view',
	'models/DriverLicenceMasterData/FilterExamStationExamRecognitionType'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
