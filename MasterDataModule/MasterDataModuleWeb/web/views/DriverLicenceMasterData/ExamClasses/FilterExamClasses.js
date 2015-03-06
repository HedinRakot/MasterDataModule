define([
	'base/base-object-filter-view',
	'models/DriverLicenceMasterData/ExamClasses/FilterExamClass'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});