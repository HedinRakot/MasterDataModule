define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/SchoolInfos',
    'l!t!DriverLicenceMasterData/FilterSchoolInfo',
    'l!t!DriverLicenceMasterData/SchoolInfoRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'SchoolInfo',
        editUrl: '#SchoolInfos',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'text', title: this.resources.text },
			];
		}
	});

	return view;
});
