define([
	'base/base-object-tab-view',
    'kendo/kendo.tabstrip'
], function (BaseView) {
    'use strict';

    var view = BaseView.extend({

        tabs: function () {
            
            var result = [
				{ view: 'l!t!DriverLicenceMasterData/ExamClassRequiredClasses', selector: '.requiredExamClasses'},
{ view: 'l!t!DriverLicenceMasterData/ExamClassInclusiveClasses', selector: '.inclusiveExamClasses'},
{ view: 'l!t!DriverLicenceMasterData/ExamClassRestrictedClasses', selector: '.restrictedClasses'},
{ view: 'l!t!DriverLicenceMasterData/ExamClassArgeMaps', selector: '.examClassArgeMaps'},
{ view: 'l!t!DriverLicenceMasterData/ExamClassMaps', selector: '.examClassMaps'},
{ view: 'l!t!DriverLicenceMasterData/ExamClassCoreDataProducts', selector: '.examClassCoreDataProducts'},
                
            ];
            
            return result;
        }
    });

    return view;
});
