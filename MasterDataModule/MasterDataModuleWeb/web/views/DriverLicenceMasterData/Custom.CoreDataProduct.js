define([
	'lr!resources/DriverLicenceMasterData/Custom.CoreDataProduct',
], function (Resources) {
	'use strict';

	var extraColumns = function () {
	    return [
            { field: 'productName', title: Resources.productName },
            { field: 'productDescription', title: Resources.productDescription },
            { field: 'insCoreDataProductName', title: Resources.insCoreDataProductName },
            { field: 'insCoreDataProductNumber', title: Resources.insCoreDataProductNumber },
	    ];
	};

	return extraColumns;
});