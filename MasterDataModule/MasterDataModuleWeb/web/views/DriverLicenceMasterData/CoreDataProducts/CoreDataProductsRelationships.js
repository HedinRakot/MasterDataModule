define([
	'base/base-object-tab-view',
    'kendo/kendo.tabstrip'
], function (BaseView) {
    'use strict';

    var view = BaseView.extend({

        tabs: function () {
            
            var result = [
                {
                view: 'l!t!DriverLicenceMasterData/CoreDataProductLocalizations/CoreDataProductLocalizations',
                selector: '.localizations'
                },
                {
                    view: 'l!t!DriverLicenceMasterData/CoreDataProductClassBasises/CoreDataProductClassBasises',
                    selector: '.examClassLegalBasises'
                },
            ];
            
            return result;
        }
    });

    return view;
});