define([
'base/base-object-grid-view',
'collections/CommonMasterData/System/SysLanguages',
'l!t!CommonMasterData/System/FilterSysLanguage'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'SysLanguage',
        editUrl: '#SysLanguages',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'sapId', title: this.resources.sapId },
				{ field: 'sapIdIso', title: this.resources.sapIdIso },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
