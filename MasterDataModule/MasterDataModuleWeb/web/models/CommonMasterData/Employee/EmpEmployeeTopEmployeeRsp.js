define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpEmployeeTopEmployeeRsps',
		fields: {
			id: { type: "number", editable: false }
			,empEmployeeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('empEmployeeTopEmployeeRsp', 'empEmployeeId'), 
				                    validation: { required: true } }			
			,topEmployeeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('empEmployeeTopEmployeeRsp', 'topEmployeeId'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
