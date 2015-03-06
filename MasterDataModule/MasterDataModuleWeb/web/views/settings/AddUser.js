define([
	'base/base-add-model-view',
	'mixins/localized-view'
], function (BaseView, LocalizedViewMixin) {
    'use strict';

    var view = BaseView.extend({
        bindings: function () {
            var result = {
                '#name': 'name',
                '#password': 'password',
                '#passwordConfirmation': 'passwordConfirmation',
                '#login': 'login',
                '#role': {
                    observe: 'role',
                    selectOptions: {
                        labelPath: 'name',
                        valuePath: 'id',
                        collection: this.options.roles,
                        defaultOption: {
                            label: this.resources.selectRole,
                            value: null
                        }
                    }
                }         
            };

            return result
        }
    });

    view.mixin(LocalizedViewMixin);

    return view;
});