define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/Languages',
    'l!t!DriverLicenceMasterData/FilterLanguage',
    'l!t!DriverLicenceMasterData/LanguageRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'Language',
        editUrl: '#Languages',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'sysLanguageId', title: this.resources.sysLanguageId },
				{ field: 'oldAbbr', title: this.resources.oldAbbr },
			];
		}
	});

	return view;
});
