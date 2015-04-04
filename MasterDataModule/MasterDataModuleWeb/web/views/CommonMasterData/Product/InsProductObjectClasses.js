define([
	'base/base-object-grid-view',
'collections/CommonMasterData/Product/InsProductObjectClasses',
'l!t!CommonMasterData/Product/FilterInsProductObjectClass',
'l!t!CommonMasterData/Product/InsProductObjectClassRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'InsProductObjectClass',
        editUrl: '#InsProductObjectClasses',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'description', title: this.resources.description },
				{ field: 'weightFrom', title: this.resources.weightFrom },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}
	});

	return view;
});
