define([
	'lr!resources/Settings/Custom.SysColumns',
], function (Resources) {
    'use strict';

    var extraColumns = function () {
        return [
            { field: 'columnDescription', title: Resources.columnDescription, filterable: false }
        ];
    };

    return extraColumns;
});