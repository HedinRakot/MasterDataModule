define([
	'base/base-object-grid-view',
'collections/Settings/ApplicationLogs',
'l!t!Settings/FilterApplicationLogs',
'l!t!Settings/ApplicationLogsRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'ApplicationLogs',
        editUrl: '#ApplicationLogs',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
			
			return [
				{ field: 'logType', title: this.resources.logType },
				{ field: 'logLevel', title: this.resources.logLevel },
				{ field: 'date', title: this.resources.date , format: '{0:d}'},
				{ field: 'message', title: this.resources.message },
			];
		}

	});

	return view;
});
