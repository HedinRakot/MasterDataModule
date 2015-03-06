define([
	'base/base-grid-view',
	'collections/settings/permissions'
], function (BaseView, PermissionCollection) {
	'use strict';

	var view = BaseView.extend({
		gridSelector: 'div',

		showAddButton: false,
		showDeleteButton: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.collection = new PermissionCollection();			
		},

		columns: function () {
			return [
				{ field: "systemName", title: this.resources.systemName },
				{ field: "name", title: this.resources.name }
			]
		}
	});

	return view;
});