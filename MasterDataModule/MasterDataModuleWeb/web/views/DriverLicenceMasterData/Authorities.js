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
				{ field: 'isCertificateRequired', title: this.resources.isCertificateRequired , headerTitle: this.resources.isCertificateRequired, checkbox: true},
				{ field: 'returnType', title: this.resources.returnType },
				{ field: 'name2', title: this.resources.name2 },
				{ field: 'streetHouseNumber', title: this.resources.streetHouseNumber },
				{ field: 'zipCode', title: this.resources.zipCode },
				{ field: 'city', title: this.resources.city },
				{ field: 'sysCountryId', title: this.resources.sysCountryId },
				{ field: 'phone1', title: this.resources.phone1 },
				{ field: 'phone2', title: this.resources.phone2 },
				{ field: 'fax', title: this.resources.fax },
			];
		}
	});

	return view;
});
