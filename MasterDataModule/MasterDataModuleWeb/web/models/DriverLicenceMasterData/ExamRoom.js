define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamRooms',
		fields: {
			id: { type: "number", editable: false }
			,roomNumber: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'roomNumber'), 
				                    validation: { required: true } }			
			,placeAmount: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'placeAmount'), 
				                    validation: { required: true } }			
			,orgOrganizationalUnitId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'orgOrganizationalUnitId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,name1: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'name1'), 
				                    validation: { required: false, maxLength: 100 } }			
			,name2: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'name2'), 
				                    validation: { required: false, maxLength: 100 } }			
			,name3: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'name3'), 
				                    validation: { required: false, maxLength: 100 } }			
			,streetHouseNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'streetHouseNumber'), 
				                    validation: { required: false, maxLength: 220 } }			
			,zipCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'zipCode'), 
				                    validation: { required: false, maxLength: 90 } }			
			,zipBox: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'zipBox'), 
				                    validation: { required: false, maxLength: 90 } }			
			,box: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'box'), 
				                    validation: { required: false, maxLength: 90 } }			
			,city: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'city'), 
				                    validation: { required: false, maxLength: 160 } }			
			,phone1: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'phone1'), 
				                    validation: { required: false, maxLength: 90 } }			
			,fax: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'fax'), 
				                    validation: { required: false, maxLength: 90 } }			
			,email: { type: "string", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'email'), 
				                    validation: { required: false, maxLength: 90 } }			
			,sysCountryId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('ExamRoom', 'sysCountryId'), 
				                    validation: { required: true } }			
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
