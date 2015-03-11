define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamPossibleResults',
    'l!t!DriverLicenceMasterData/FilterExamPossibleResult',
    'l!t!DriverLicenceMasterData/ExamPossibleResultRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ExamPossibleResult',
        editUrl: '#ExamPossibleResults',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
				{ field: 'isFeePayable', title: this.resources.isFeePayable , headerTitle: this.resources.isFeePayable, checkbox: true},
				{ field: 'examCounterFlag', title: this.resources.examCounterFlag , headerTitle: this.resources.examCounterFlag, checkbox: true},
				{ field: 'nextExamProductFlag', title: this.resources.nextExamProductFlag , headerTitle: this.resources.nextExamProductFlag, checkbox: true},
				{ field: 'driverLicenceFlag', title: this.resources.driverLicenceFlag , headerTitle: this.resources.driverLicenceFlag, checkbox: true},
				{ field: 'isMedicalAttestRequired', title: this.resources.isMedicalAttestRequired , headerTitle: this.resources.isMedicalAttestRequired, checkbox: true},
			];
		}
	});

	return view;
});
