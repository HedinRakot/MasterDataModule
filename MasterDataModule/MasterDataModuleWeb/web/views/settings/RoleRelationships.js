define([
	'base/base-object-tab-view',
    'kendo/kendo.tabstrip'
], function (BaseView) {
    'use strict';

    var view = BaseView.extend({

        tabs: function () {
            
            var result = [
				{ view: 'l!t!Settings/MasterDataRolePermissionRsps', selector: '.Permissions'},
                
            ];
            
            return result;
        }
    });

    return view;
});
