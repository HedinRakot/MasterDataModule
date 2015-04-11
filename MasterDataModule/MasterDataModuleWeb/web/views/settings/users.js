define([
'base/base-object-grid-view',
'collections/Settings/Users',
'l!t!Settings/FilterUser',
'Settings/Custom.User',
'Settings/Custom.Events.User'
], function (BaseView, Collection, FilterView, CustomColumns, CustomEvents) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'User',
        editUrl: '#Users',
		
		
		showEditButton: true,
		showDeleteButton: true,

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
