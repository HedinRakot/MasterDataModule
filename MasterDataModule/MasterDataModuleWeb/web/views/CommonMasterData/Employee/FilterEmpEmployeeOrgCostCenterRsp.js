define([
	'base/base-object-filter-view',
	'models/CommonMasterData/Employee/FilterEmpEmployeeOrgCostCenterRsp'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
