define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/LegalBasises',
    'l!t!DriverLicenceMasterData/LegalBasises/FilterLegalBasises',
    'l!t!DriverLicenceMasterData/LegalBasises/LegalBasisesRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
	    detailView: DetailView,
        filterView: FilterView,
        tableName: 'legalBasis',
        editUrl: '#LegalBasises',

        editItemTitle: function () {
            return this.resources.edit
        },
        
		columns: function () {
		    return [
		        { field: 'name', title: this.resources.name, width: '130px' },
		        { field: 'description', title: this.resources.description },
		        { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
		    ];
		}
	});

	return view;
});