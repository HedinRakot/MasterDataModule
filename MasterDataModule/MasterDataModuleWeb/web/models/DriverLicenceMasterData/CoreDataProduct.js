define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/CoreDataProducts',
		fields: {
			id: { type: "number", editable: false }
			,insCoreDataProductId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'insCoreDataProductId'), 
				                    validation: { required: true } }			
			,minAge: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'minAge'), 
				                    validation: { required: true } }			
			,maxAge: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'maxAge'), 
				                    validation: { required: false } }			
			,examType: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'examType'), 
				                    validation: { required: true } }			
			,priorTimeInMonths: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'priorTimeInMonths'), 
				                    validation: { required: true } }			
			,expirationInMonth: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'expirationInMonth'), 
				                    validation: { required: true } }			
			,repeatTimeInDays: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'repeatTimeInDays'), 
				                    validation: { required: true } }			
			,trainingCertFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'trainingCertFlag'), 
				                    validation: { required: false } }			
			,resultFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'resultFlag'), 
				                    validation: { required: false } }			
			,multiplyFlag: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'multiplyFlag'), 
				                    validation: { required: false } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'toDate'), 
				                    validation: { required: true, date: true } }			
			,isMofaPrint: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'isMofaPrint'), 
				                    validation: { required: false } }			
			,isAdditionalProduct: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'isAdditionalProduct'), 
				                    validation: { required: false } }			
			,isPrepaymentRequired: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'isPrepaymentRequired'), 
				                    validation: { required: false } }			
			,isMandatory: { type: "boolean", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'isMandatory'), 
				                    validation: { required: false } }			
			,feProductNumber: { type: "string", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'feProductNumber'), 
				                    validation: { required: true, maxLength: 10 } }			
			,repeatTimeInDaysReduced: { type: "number", 
			                        editable: Application.canTableItemBeEdit('coreDataProduct', 'repeatTimeInDaysReduced'), 
				                    validation: { required: true } }			
		}
	});
	return model;
});
