define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpEmployees',
		fields: {
			id: { type: "number", editable: false }
			,personalNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'personalNumber'), 
				                    validation: { required: true, maxLength: 10 } }			
			,domain: { type: "string", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'domain'), 
				                    validation: { required: false, maxLength: 90 } }			
			,userName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'userName'), 
				                    validation: { required: false, maxLength: 50 } }			
			,windowsUserName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'windowsUserName'), 
				                    validation: { required: false, maxLength: 90 } }			
			,isSsoAllowed: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'isSsoAllowed'), 
				                    validation: { required: false } }			
			,isEmergencyLoginAllowed: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'isEmergencyLoginAllowed'), 
				                    validation: { required: false } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'name'), 
				                    validation: { required: false, maxLength: 90 } }			
			,middleName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'middleName'), 
				                    validation: { required: false, maxLength: 90 } }			
			,lastName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'lastName'), 
				                    validation: { required: false, maxLength: 90 } }			
			,comment: { type: "string", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'comment'), 
				                    validation: { required: false, maxLength: 90 } }			
			,sexType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'sexType'), 
				                    validation: { required: false } }			
			,title: { type: "string", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'title'), 
				                    validation: { required: false, maxLength: 90 } }			
			,birthdate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'birthdate'), 
				                    validation: { required: false, date: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('EmpEmployee', 'toDate'), 
				                    validation: { required: true, date: true } }			
		},
		defaults: function () {
			var dnf = new Date();
			var dnt = new Date(2070,11,31);
			return {
				fromDate: dnf, 
				toDate: dnt
			};
		}
	});
	return model;
});
