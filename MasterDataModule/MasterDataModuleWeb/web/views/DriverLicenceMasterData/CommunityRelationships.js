define([
	'base/base-object-tab-view',
    'kendo/kendo.tabstrip'
], function (BaseView) {
    'use strict';

    var view = BaseView.extend({

        tabs: function () {
            
            var result = [
				{ view: 'l!t!DriverLicenceMasterData/CommunityParticipants', selector: '.community'},
                
            ];
            
            return result;
        }
    });

    return view;
});
