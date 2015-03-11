define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/System/SysCountries',
    'l!t!CommonMasterData/System/FilterSysCountry',
    'l!t!CommonMasterData/System/SysCountryRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'SysCountry',
        editUrl: '#SysCountries',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'sapId', title: this.resources.sapId },
				{ field: 'name', title: this.resources.name },
				{ field: 'isEu', title: this.resources.isEu , headerTitle: this.resources.isEu, checkbox: true},
			];
		}
	});

	return view;
});
