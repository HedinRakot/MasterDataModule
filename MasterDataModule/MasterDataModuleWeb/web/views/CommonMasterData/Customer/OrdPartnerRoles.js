define([
'base/base-object-grid-view',
'collections/CommonMasterData/Customer/OrdPartnerRoles',
'l!t!CommonMasterData/Customer/FilterOrdPartnerRole'
], function (BaseView, Collection, FilterView) {
	'use strict';		
	var view = BaseView.extend({

        collectionType: Collection,
        
        filterView: FilterView,
        tableName: 'OrdPartnerRole',
        editUrl: '#OrdPartnerRoles',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		columns: function () {
			
			return [
				{ field: 'sapQualifier', title: this.resources.sapQualifier },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		}

	});

	return view;
});
