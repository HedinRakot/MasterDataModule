define([
	'base/base-object-tab-view',
    'kendo/kendo.tabstrip'
], function (BaseView) {
    'use strict';

    var view = BaseView.extend({

        tabs: function () {
            
            var result = [
				{ view: 'l!t!DriverLicenceMasterData/ExamStationExamRecognitionTypes', selector: '.examRecognitionTypes'},
                
            ];
            
            return result;
        }
    });

    return view;
});
