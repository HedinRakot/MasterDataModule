define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/LegalBases',
    'l!t!DriverLicenceMasterData/FilterLegalBasis',
    'l!t!DriverLicenceMasterData/LegalBasisRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'LegalBasis',
        editUrl: '#LegalBases',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
				{ field: 'educationCertificateRequired', title: this.resources.educationCertificateRequired , headerTitle: this.resources.educationCertificateRequired, checkbox: true},
				{ field: 'firstAssignation', title: this.resources.firstAssignation },
				{ field: 'messageReason', title: this.resources.messageReason },
				{ field: 'messageReasonStyle', title: this.resources.messageReasonStyle },
				{ field: 'replacementId', title: this.resources.replacementId },
				{ field: 'printName', title: this.resources.printName },
			];
		}
	});

	return view;
});
