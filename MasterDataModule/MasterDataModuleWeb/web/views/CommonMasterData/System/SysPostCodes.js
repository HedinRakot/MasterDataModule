define([
	'base/base-object-grid-view',
'collections/CommonMasterData/System/SysPostCodes',
'l!t!CommonMasterData/System/FilterSysPostCode',
'l!t!CommonMasterData/System/SysPostCodeRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'SysPostCode',
        editUrl: '#SysPostCodes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'postCode', title: this.resources.postCode },
				{ field: 'city', title: this.resources.city },
				{ field: 'street', title: this.resources.street },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
