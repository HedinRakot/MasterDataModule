define([
	'base/base-object-tab-view',
    'kendo/kendo.tabstrip'
], function (BaseView) {
    'use strict';

    var view = BaseView.extend({

        tabs: function () {
            
            var result = [
				{ view: 'l!t!DriverLicenceMasterData/DriverSchoolExamRecognitionTypes', selector: '.examRecognitions'},
{ view: 'l!t!DriverLicenceMasterData/DriverSchoolInfos', selector: '.driverSchoolInfo'},
                
            ];
            
            return result;
        }
    });

    return view;
});
