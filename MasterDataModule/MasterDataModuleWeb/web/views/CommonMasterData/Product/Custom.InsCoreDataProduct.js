define([
	'lr!resources/CommonMasterData/Product/Custom.InsCoreDataProduct',
], function (Resources) {
	'use strict';

	var extraColumns = function () {
	    return [
            { field: 'productName', title: Resources.productName },
            { field: 'productDescription', title: Resources.productDescription },
	    ];
	};

	return extraColumns;
});