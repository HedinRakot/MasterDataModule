define([
'base/base-object-grid-view',
'collections/CommonMasterData/Product/InsProductObjectClasses',
'l!t!CommonMasterData/Product/FilterInsProductObjectClass'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'InsProductObjectClass',
        editUrl: '#InsProductObjectClasses',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'description', title: this.resources.description },
				{ field: 'weightFrom', title: this.resources.weightFrom },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
