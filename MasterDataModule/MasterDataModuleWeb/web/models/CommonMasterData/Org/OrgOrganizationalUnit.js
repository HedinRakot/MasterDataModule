define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/OrgOrganizationalUnits',
		fields: {
			id: { type: "number", editable: false }
			,orgNumber: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'orgNumber'), 
				                    validation: { required: true } }			
			,name: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'name'), 
				                    validation: { required: false, maxLength: 50 } }			
			,abbr: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'abbr'), 
				                    validation: { required: false, maxLength: 50 } }			
			,locationAbbr: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'locationAbbr'), 
				                    validation: { required: false, maxLength: 50 } }			
			,sysLocationId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'sysLocationId'), 
				                    validation: { required: false } }			
			,orgTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'orgTypeId'), 
				                    validation: { required: true } }			
			,emailFrom: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'emailFrom'), 
				                    validation: { required: false, maxLength: 100 } }			
			,emailTo: { type: "string", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'emailTo'), 
				                    validation: { required: false, maxLength: 512 } }			
			,isEgdokPrintAlways: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'isEgdokPrintAlways'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,orgAccountingAreaId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'orgAccountingAreaId'), 
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
