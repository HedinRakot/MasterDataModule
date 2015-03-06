define([
	'base/base-object-tab-view',
    'kendo/kendo.tabstrip'
], function (BaseView) {
    'use strict';

    var view = BaseView.extend({

        tabs: function () {
            
            var result = [{
                view: 'l!t!DriverLicenceMasterData/RequiredExamClasses/RequiredExamClasses',
                selector: '.requiredExamClasses'
                },
                {
                    view: 'l!t!DriverLicenceMasterData/InclusiveExamClasses/InclusiveExamClasses',
                    selector: '.inclusiveExamClasses'
                },
                {
                    view: 'l!t!DriverLicenceMasterData/ExamClasses/CoreDataProducts',
                    selector: '.products'
                }];
            
            return result;
        }
    });

    return view;
});