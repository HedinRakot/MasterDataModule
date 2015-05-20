define([
'base/base-object-grid-view',
'collections/Settings/SysTables',
'l!t!Settings/FilterSysTable',
'l!t!Settings/SysTableRelationships',
'Settings/Custom.SysTable'
], function (BaseView, Collection, FilterView, DetailView, CustomColumns) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'SysTable',
        editUrl: '#SysTables',
		addNewModelInline: true,
		
		showEditButton: true,
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return $.merge( CustomColumns(),
[
				{ field: 'editMode', title: this.resources.editMode , collection: this.options.editModeType, defaultText: this.resources.pleaseSelect},
			]);
		}

	});

	return view;
});
