define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/EmpEmployees',
		fields: {
			id: { type: "number", editable: false }
			,personalNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'personalNumber'), 
				                    validation: { required: true, maxLength: 10 } }			
			,domain: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'domain'), 
				                    validation: { required: false, maxLength: 90 } }			
			,userName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'userName'), 
				                    validation: { required: false, maxLength: 50 } }			
			,windowsUserName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'windowsUserName'), 
				                    validation: { required: false, maxLength: 90 } }			
			,isSsoAllowed: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'isSsoAllowed'), 
				                    validation: { required: false } }			
			,isEmergencyLoginAllowed: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'isEmergencyLoginAllowed'), 
				                    validation: { required: false } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'name'), 
				                    validation: { required: false, maxLength: 90 } }			
			,middleName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'middleName'), 
				                    validation: { required: false, maxLength: 90 } }			
			,lastName: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'lastName'), 
				                    validation: { required: false, maxLength: 90 } }			
			,comment: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'comment'), 
				                    validation: { required: false, maxLength: 90 } }			
			,sexType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'sexType'), 
				                    validation: { required: false } }			
			,title: { type: "string", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'title'), 
				                    validation: { required: false, maxLength: 90 } }			
			,birthdate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'birthdate'), 
				                    validation: { required: false, date: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('empEmployee', 'toDate'), 
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
