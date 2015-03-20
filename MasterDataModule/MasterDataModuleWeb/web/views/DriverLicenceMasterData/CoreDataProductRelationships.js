define([
	'base/base-object-tab-view',
    'kendo/kendo.tabstrip'
], function (BaseView) {
    'use strict';

    var view = BaseView.extend({

        tabs: function () {
            
            var result = [
				{ view: 'l!t!DriverLicenceMasterData/CoreDataProductLocalizations', selector: '.localizations'},
{ view: 'l!t!DriverLicenceMasterData/CoreDataProductClassBases', selector: '.classBasisRsp'},
                
            ];
            
            return result;
        }
    });

    return view;
});
