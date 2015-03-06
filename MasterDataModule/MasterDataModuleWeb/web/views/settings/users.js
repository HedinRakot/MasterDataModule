define([
	'base/base-grid-view',
	'collections/settings/users',
	't!settings/addUser'	
], function (BaseView, UsersCollection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({
		addNewModelView: AddNewModelView,

		gridSelector: 'div',

		addingInPopup: true,

		initialize: function () {
			view.__super__.initialize.apply(this, arguments);

			this.collection = new UsersCollection();
		},

		events: {
			'click .change-password a': function (e) {
				e.preventDefault();

				var self = this,
					dataItem = self.grid.dataItem($(e.target).closest('tr'));

				require(['models/settings/user', 't!settings/changePassword'], function (Model, View) {
					var view = new View({ model: new Model({ id: dataItem.id }) });
					view.resources = self.resources;

					self.addView(view);
					self.$el.append(view.render().$el);
				});
			}
		},

		columns: function () {
			var self = this,
				result = [
				{ field: 'login', title: self.resources.login },
				{ field: 'name', title: self.resources.name },
				{ field: 'role', title: self.resources.role, collection: self.options.roles },
				{
					attributes: { 'class': 'change-password' },
					command: { name: 'change-password', text: self.resources.changePassword }
				}];

			return result;
		}
	});

	return view;
});