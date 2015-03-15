define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Org/OrgCostCenterResponsibleEmployeeRsps',
    'l!t!CommonMasterData/Org/FilterOrgCostCenterResponsibleEmployeeRsp',
    'l!t!CommonMasterData/Org/OrgCostCenterResponsibleEmployeeRspRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgCostCenterResponsibleEmployeeRsp',
        editUrl: '#OrgCostCenterResponsibleEmployeeRsps',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'empEmployeeId', title: this.resources.empEmployeeId },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
