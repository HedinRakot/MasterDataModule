define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'EmpEmployees': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Employee/EmpEmployees'),
	            'EmpEmployees/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpEmployee', 'models/CommonMasterData/Employee/EmpEmployee', false),
	            'EmpEmployees/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpEmployee', 'models/CommonMasterData/Employee/EmpEmployee', false),
				'EmpCashPermissionTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Employee/EmpCashPermissionTypes'),
	            'EmpCashPermissionTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpCashPermissionType', 'models/CommonMasterData/Employee/EmpCashPermissionType', false),
	            'EmpCashPermissionTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpCashPermissionType', 'models/CommonMasterData/Employee/EmpCashPermissionType', false),
				'EmpOrgAssociationTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Employee/EmpOrgAssociationTypes'),
	            'EmpOrgAssociationTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpOrgAssociationType', 'models/CommonMasterData/Employee/EmpOrgAssociationType', false),
	            'EmpOrgAssociationTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpOrgAssociationType', 'models/CommonMasterData/Employee/EmpOrgAssociationType', false),
				'EmpEmployeeTopEmployeeRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Employee/EmpEmployeeTopEmployeeRsps'),
	            'EmpEmployeeTopEmployeeRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpEmployeeTopEmployeeRsp', 'models/CommonMasterData/Employee/EmpEmployeeTopEmployeeRsp', false),
	            'EmpEmployeeTopEmployeeRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpEmployeeTopEmployeeRsp', 'models/CommonMasterData/Employee/EmpEmployeeTopEmployeeRsp', false),
				'EmpEmployeeSysRoleRsps': _.partial(BaseRouter.showView, baseRouter, 'l!t!CommonMasterData/Employee/EmpEmployeeSysRoleRsps'),
	            'EmpEmployeeSysRoleRsps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpEmployeeSysRoleRsp', 'models/CommonMasterData/Employee/EmpEmployeeSysRoleRsp', false),
	            'EmpEmployeeSysRoleRsps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!CommonMasterData/Employee/AddEmpEmployeeSysRoleRsp', 'models/CommonMasterData/Employee/EmpEmployeeSysRoleRsp', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
