define([
	'base/base-object-filter-view',
	'models/DriverLicenceMasterData/FilterExamRecognitionTypeExamClass'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
