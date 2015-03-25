define(function () {
	'use strict';

	var model = Backbone.Model.extend({
	    urlRoot: 'api/InsPfpInspectionTypePfpPositionRsps',
		fields: {
			id: { type: "number", editable: false }
			,insPfpPositionId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insPfpInspectionTypePfpPositionRsp', 'insPfpPositionId'), 
				                    validation: { required: true } }			
			,insPfpInspectionTypeId: { type: "number", 
			                        editable: Application.canTableItemBeEdit('insPfpInspectionTypePfpPositionRsp', 'insPfpInspectionTypeId'), 
				                    validation: { required: true } }			
			,fromDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insPfpInspectionTypePfpPositionRsp', 'fromDate'), 
				                    validation: { required: true, date: true } }			
			,toDate: { type: "date", 
			                        editable: Application.canTableItemBeEdit('insPfpInspectionTypePfpPositionRsp', 'toDate'), 
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
