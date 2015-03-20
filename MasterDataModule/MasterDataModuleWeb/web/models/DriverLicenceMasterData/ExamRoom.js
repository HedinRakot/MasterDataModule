define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/ExamRooms',
		fields: {
			id: { type: "number", editable: false }
			,roomNumber: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'roomNumber'), 
				                    validation: { required: true } }			
			,placeAmount: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'placeAmount'), 
				                    validation: { required: false } }			
			,orgOrganizationalUnitId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'orgOrganizationalUnitId'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,name1: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'name1'), 
				                    validation: { required: false, maxLength: 100 } }			
			,name2: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'name2'), 
				                    validation: { required: false, maxLength: 100 } }			
			,name3: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'name3'), 
				                    validation: { required: false, maxLength: 100 } }			
			,streetHouseNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'streetHouseNumber'), 
				                    validation: { required: false, maxLength: 220 } }			
			,zipCode: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'zipCode'), 
				                    validation: { required: false, maxLength: 90 } }			
			,zipBox: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'zipBox'), 
				                    validation: { required: false, maxLength: 90 } }			
			,box: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'box'), 
				                    validation: { required: false, maxLength: 90 } }			
			,city: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'city'), 
				                    validation: { required: false, maxLength: 160 } }			
			,phone1: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'phone1'), 
				                    validation: { required: false, maxLength: 90 } }			
			,fax: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'fax'), 
				                    validation: { required: false, maxLength: 90 } }			
			,email: { type: "string", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'email'), 
				                    validation: { required: false, maxLength: 90 } }			
			,sysCountryId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('examRoom', 'sysCountryId'), 
				                    validation: { required: false } }			
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
