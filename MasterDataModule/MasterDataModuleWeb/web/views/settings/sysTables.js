define([
	'base/base-object-grid-view',
'collections/Settings/SysTables',
'l!t!Settings/FilterSysTable',
'l!t!Settings/SysTableRelationships'

], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'SysTable',
        editUrl: '#SysTables',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'description', title: this.resources.description },
				{ field: 'editMode', title: this.resources.editMode , collection: this.options.editModeType, defaultText: this.resources.pleaseSelect},
			];
		}
	});

	return view;
});
