define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Employee/EmpEmployeeTopEmployeeRsps',
    'l!t!CommonMasterData/Employee/FilterEmpEmployeeTopEmployeeRsp',
    'l!t!CommonMasterData/Employee/EmpEmployeeTopEmployeeRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'EmpEmployeeTopEmployeeRsp',
        editUrl: '#EmpEmployeeTopEmployeeRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'empEmployeeId', title: this.resources.empEmployeeId },
				{ field: 'topEmployeeId', title: this.resources.topEmployeeId },
			];
		}
	});

	return view;
});
