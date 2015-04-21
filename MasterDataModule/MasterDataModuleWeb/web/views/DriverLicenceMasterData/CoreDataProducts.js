define([
'base/base-object-grid-view',
'collections/DriverLicenceMasterData/CoreDataProducts',
'l!t!DriverLicenceMasterData/FilterCoreDataProduct',
'l!t!DriverLicenceMasterData/CoreDataProductRelationships',
'DriverLicenceMasterData/Custom.CoreDataProduct',
'jszip'
], function (BaseView, Collection, FilterView, DetailView, CustomColumns, JSZip) {
	'use strict';		
	window.JSZip = JSZip;
	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'CoreDataProduct',
        editUrl: '#CoreDataProducts',
		
		
		
		

	    editItemTitle: function () {
	        return this.resources.edit;
	    },
		toolbar: function () {
            var result = view.__super__.toolbar.apply(this, arguments);

            result.push({ template: function () { return '<a class="k-button k-button-icontext k-grid-excel" href="#"><span class="k-icon k-i-excel"></span>Excel</a>'; } });

            return result;
        },
		columns: function () {
			
			return $.merge( CustomColumns(),
[
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			]);
		}

	});

	return view;
});
