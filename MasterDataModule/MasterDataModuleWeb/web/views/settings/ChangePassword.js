define([
	'base/base-window-view',
	'mixins/kendo-validator-form',
	'mixins/localized-view',
	'mixins/bound-form'
], function (BaseView, KendoValidatorFormMixin, LocalizedViewMixin, BoundForm) {
	'use strict';

	var view = BaseView.extend({
		title: function () {
			return this.resources.changePassword;
		},
		events: {
			'click button[type=submit]': function (e) {
				e.preventDefault();
				var self = this;

				if (self.validate()) {
					self.model.url = 'api/users',
					self.model.save({
						id: self.model.id,
						password: self.model.get('password'),
						passwordConfirmation: self.model.get('passwordConfirmation')
					}, {
						patch: true,
						success: function () {
							self.close();
						},
						error: function (model, response) {
						    self.validateResponse(response);
						}
					});
				}
			}			
		},

		bindings: {
			'#password': 'password',
			'#passwordConfirmation': 'passwordConfirmation',
		},

		render: function () {
			view.__super__.render.apply(this, arguments);

			this.stickit();

			return this;
		}
	});

	view.mixin(KendoValidatorFormMixin);
	view.mixin(LocalizedViewMixin);
	view.mixin(BoundForm);

	return view;
});