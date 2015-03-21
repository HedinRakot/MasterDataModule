define([
	'base/base-object-grid-view',
'collections/DriverLicenceMasterData/MessageLocalizations',
'l!t!DriverLicenceMasterData/FilterMessageLocalization',
'l!t!DriverLicenceMasterData/MessageLocalizationRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'MessageLocalization',
        editUrl: '#MessageLocalizations',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'validationErrorNumber', title: this.resources.validationErrorNumber },
				{ field: 'sysLanguageId', title: this.resources.sysLanguageId , collection: this.options.sysLanguage, filterable: false},
				{ field: 'message', title: this.resources.message },
			];
		}
	});

	return view;
});
