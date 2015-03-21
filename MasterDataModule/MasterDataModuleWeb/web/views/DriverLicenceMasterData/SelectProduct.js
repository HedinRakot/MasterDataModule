define([
	'base/base-window-view',
    'l!t!DriverLicenceMasterData/InsCoreDataProducts',
], function (BaseView, ProductsView) {
    'use strict';

    var view = BaseView.extend({
        width: '1060px',
        title: function () { return this.resources.title; },
        render: function () {
            var self = this;

            view.__super__.render.apply(this, arguments);

            var options = {
                success: function (model) {
                    self.trigger('select', model);
                    self.close();
                },
                cancel: function () {
                    self.close();
                }
            };

            var productsView = new ProductsView(options);
            self.showView(productsView, '.products');

            return this;
        },

        open: function (e) {
            this.kendoWindow.wrapper.css({ top: 100 });
        }
    });

    return view;
});