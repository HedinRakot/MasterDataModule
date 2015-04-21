define([
'base/base-object-grid-view',
'collections/DriverLicenceMasterData/Languages',
'l!t!DriverLicenceMasterData/FilterLanguage'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'Language',
        editUrl: '#Languages',
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'sysLanguageId', title: this.resources.sysLanguageId , collection: this.options.sysLanguage, defaultText: this.resources.pleaseSelect},
				{ field: 'oldAbbr', title: this.resources.oldAbbr },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
