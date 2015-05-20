define([
'base/base-object-grid-view',
'collections/Settings/LogTypeInfos',
'l!t!Settings/FilterLogTypeInfo'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'LogTypeInfo',
        editUrl: '#LogTypeInfos',
		addNewModelInline: true,
		showAddButton: true,
		showEditButton: true,
		showDeleteButton: true,

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'fileName', title: this.resources.fileName },
				{ field: 'filePattern', title: this.resources.filePattern },
				{ field: 'filePath', title: this.resources.filePath },
			];
		}

	});

	return view;
});
