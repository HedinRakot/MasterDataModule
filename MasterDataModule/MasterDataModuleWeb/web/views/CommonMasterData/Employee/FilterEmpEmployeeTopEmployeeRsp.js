define([
	'base/base-object-filter-view',
	'models/CommonMasterData/Employee/FilterEmpEmployeeTopEmployeeRsp'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
