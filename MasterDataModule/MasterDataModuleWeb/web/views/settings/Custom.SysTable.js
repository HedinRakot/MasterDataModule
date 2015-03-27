define([
	'lr!resources/Settings/Custom.SysTables',
], function (Resources) {
    'use strict';

    var extraColumns = function () {
        return [
            { field: 'tableDescription', title: Resources.tableDescription, filterable: false }
        ];
    };

    return extraColumns;
});