define([
	'lr!resources/DriverLicenceMasterData/Custom.CoreDataProduct',
], function (Resources) {
	'use strict';

	var extraColumns = function () {
	    return [
            { field: 'productName', title: Resources.productName, filterable: false },
            { field: 'productDescription', title: Resources.productDescription, filterable: false },
            { field: 'insCoreDataProductName', title: Resources.insCoreDataProductName, filterable: false, sortable: false },
            { field: 'insCoreDataProductNumber', title: Resources.insCoreDataProductNumber, filterable: false, sortable: false },
	    ];
	};

	return extraColumns;
});