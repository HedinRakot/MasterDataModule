define([
	'base/base-object-grid-view',
'collections/Settings/Users',
'l!t!Settings/FilterUser',
'l!t!Settings/UserRelationships',
'Settings/Custom.User',
'Settings/Custom.Events.User'
], function (BaseView, Collection, FilterView, DetailView, CustomColumns, CustomEvents) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'User',
        editUrl: '#Users',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return $.merge( CustomColumns(),
[
				{ field: 'masterDataRoleId', title: this.resources.masterDataRoleId , collection: this.options.role, defaultText: this.resources.pleaseSelect},
				{ field: 'login', title: this.resources.login },
				{ field: 'name', title: this.resources.name },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			]);
		}

		,events: CustomEvents
	});

	return view;
});
