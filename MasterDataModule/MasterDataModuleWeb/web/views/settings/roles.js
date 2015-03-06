define([
	'base/base-grid-view',
	'collections/settings/roles',
	't!settings/addRole'
], function (BaseView, RolesCollection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		gridSelector: 'div',

        addingInPopup: true,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);			

			this.collection = new RolesCollection();
		},

		columns: function () {
			var result = [
				{ field: 'name', title: this.resources.name },
				{ field: 'permissions', title: this.resources.permissions, sortable: false, selectBox: true, collection: this.options.permissions }
			];

			return result;
		}
	});

	return view;
});