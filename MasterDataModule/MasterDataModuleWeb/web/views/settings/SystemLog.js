define([
	'base/base-grid-view',
	'collections/settings/systemLog'
], function (BaseView, Collection) {
	'use strict';

	var view = BaseView.extend({
		gridSelector: 'div',

		showAddButton: false,
		showDeleteButton: false,
		showEditButton: false,

		defautSorting: {
			field: 'date',
			dir: 'desc'
		},

		initialize: function () {
			view.__super__.initialize.apply(this, arguments);

			this.collection = new Collection();
		},

		columns: function () {
			return [
				{ field: "date", title: 'Дата', format: '{0:g}', width: '150px' },
				{ field: "userLogin", title: 'ФИО (Логин)' },
				{ field: "description", title: 'Описание', sortable: false, filterable: false }
			]
		}
	});

	return view;
});