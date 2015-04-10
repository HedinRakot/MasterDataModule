define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/CoreDataProducts',
		fields: {
			id: { type: "number", editable: false }
			,insCoreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'insCoreDataProductId'), 
				                    validation: { required: true } }			
			,minAge: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'minAge'), 
				                    validation: { required: true } }			
			,maxAge: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'maxAge'), 
				                    validation: { required: false } }			
			,examType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'examType'), 
				                    validation: { required: true } }			
			,priorTimeInMonths: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'priorTimeInMonths'), 
				                    validation: { required: true } }			
			,expirationInMonth: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'expirationInMonth'), 
				                    validation: { required: true } }			
			,repeatTimeInDays: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'repeatTimeInDays'), 
				                    validation: { required: true } }			
			,trainingCertFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'trainingCertFlag'), 
				                    validation: { required: false } }			
			,resultFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'resultFlag'), 
				                    validation: { required: false } }			
			,multiplyFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'multiplyFlag'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,isMofaPrint: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'isMofaPrint'), 
				                    validation: { required: false } }			
			,isAdditionalProduct: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'isAdditionalProduct'), 
				                    validation: { required: false } }			
			,isPrepaymentRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'isPrepaymentRequired'), 
				                    validation: { required: false } }			
			,isMandatory: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'isMandatory'), 
				                    validation: { required: false } }			
			,feProductNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'feProductNumber'), 
				                    validation: { required: true, maxLength: 10 } }			
			,repeatTimeInDaysReduced: { type: "number", 
			                        editable: Application.canTableItemBeEdit('CoreDataProduct', 'repeatTimeInDaysReduced'), 
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
