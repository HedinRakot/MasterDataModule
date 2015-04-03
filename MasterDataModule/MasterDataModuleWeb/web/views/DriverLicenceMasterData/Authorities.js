define([
	'base/base-object-grid-view',
'collections/DriverLicenceMasterData/Authorities',
'l!t!DriverLicenceMasterData/FilterAuthority',
'l!t!DriverLicenceMasterData/AuthorityRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'Authority',
        editUrl: '#Authorities',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'authorityNumber', title: this.resources.authorityNumber },
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
