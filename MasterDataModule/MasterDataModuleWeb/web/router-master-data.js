define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {

	            'ExamClasses': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ExamClasses'),
	            'ExamClasses/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamClass', 'models/DriverLicenceMasterData/ExamClass', false),
	            'ExamClasses/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamClass', 'models/DriverLicenceMasterData/ExamClass', false),

	            //'LegalBasises': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/LegalBasises/LegalBasises', { examClasses: true }),
	            //'LegalBasises/create': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/LegalBasises/AddLegalBasis'),
	            //'LegalBasises/:id': _.partial(showViewWithModel,  'l!t!DriverLicenceMasterData/LegalBasises/AddLegalBasis', ''),

	            //'ExamRecognitionTypes': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/ExamRecognitionTypes/ExamRecognitionTypes', { examClasses: true }),
	            //'ExamRecognitionTypes/create': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/ExamRecognitionTypes/AddExamRecognitionType'),
	            //'ExamRecognitionTypes/:id': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/ExamRecognitionTypes/AddExamRecognitionType', ''),

	            //'ReturnReasons': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/ReturnReasons/ReturnReasons'),
	            //'ReturnReasons/create': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/ReturnReasons/AddReturnReason'),
	            //'ReturnReasons/:id': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/ReturnReason/AddReturnReason', ''),


	            //'CoreDataProducts': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/CoreDataProducts/CoreDataProducts', {
	            //    sysLanguages: true,
	            //    legalBasises: true,
	            //    examClasses: true,
	            //}),
	            //'CoreDataProducts/create': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/CoreDataProducts/AddCoreDataProduct'),
	            //'CoreDataProducts/:id': _.partial(showViewWithModel, 'l!t!DriverLicenceMasterData/CoreDataProducts/AddCoreDataProduct', ''),


	            //'InsCoreDataProducts': _.partial(showViewWithModel, 'l!t!CommonMasterData/Product/InsCoreDataProducts/InsCoreDataProducts', {
	            //    sysLanguages: true,
	            //}),
	            //'InsCoreDataProducts/create': _.partial(showViewWithModel, 'l!t!CommonMasterData/Product/InsCoreDataProducts/AddInsCoreDataProduct'),
	            //'InsCoreDataProducts/:id': _.partial(showViewWithModel, 'l!t!CommonMasterData/Product/InsCoreDataProducts/AddInsCoreDataProduct', 'models/document', false),

	            //'OrgOrganizationalUnits': _.partial(showViewWithModel, 'l!t!CommonMasterData/Org/OrganizationalUnits/OrganizationalUnits'),
	            //'OrgOrganizationalUnits/create': _.partial(showViewWithModel, 'l!t!CommonMasterData/Org/OrgOrganizationalUnits/AddOrgOrganizationalUnit'),
	            //'OrgOrganizationalUnits/:id': _.partial(showViewWithModel, 'l!t!CommonMasterData/Org/OrgOrganizationalUnits/AddOrganizationalUnit', 'models/document', false),

	            //'EmpEmployees': _.partial(showViewWithModel, 'l!t!CommonMasterData/Employee/EmpEmployees/EmpEmployees'),
	            //'EmpEmployees/create': _.partial(showViewWithModel, 'l!t!CommonMasterData/Employee/EmpEmployees/AddEmpEmployee'),
	            //'EmpEmployees/:id': _.partial(showViewWithModel, 'l!t!CommonMasterData/Employee/EmpEmployees/AddEmpEmployee', 'models/document', false),
	        }
        
	        return routes;
	    }
	};

	return factory;
});