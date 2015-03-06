define([
	'base/base-add-model-view',
	'mixins/localized-view'
], function (BaseView, LocalizedViewMixin) {
	'use strict';

	var view = BaseView.extend({
		bindings: function () {
			var result = {
				'#name': 'name',
				'#permissions': {
				    observe: 'permissions',
					selectOptions: {
						labelPath: 'name',
						valuePath: 'id',
						collection: this.options.permissions
					}
				}
			}

			return result;
		}
	});

	view.mixin(LocalizedViewMixin);

	return view;
});