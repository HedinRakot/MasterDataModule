define([
'base/base-object-grid-view',
'collections/DriverLicenceMasterData/MessageLocalizations',
'l!t!DriverLicenceMasterData/FilterMessageLocalization'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'MessageLocalization',
        editUrl: '#MessageLocalizations',
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'validationErrorNumber', title: this.resources.validationErrorNumber },
				{ field: 'sysLanguageId', title: this.resources.sysLanguageId , collection: this.options.sysLanguage, defaultText: this.resources.pleaseSelect},
				{ field: 'message', title: this.resources.message },
			];
		}

	});

	return view;
});
