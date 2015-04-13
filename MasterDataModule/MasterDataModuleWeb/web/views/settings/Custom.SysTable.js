define([
	'lr!resources/Settings/Custom.SysTables',
], function (Resources) {
    'use strict';

    var extraColumns = function () {
        return [
            {
                title: Resources.tableDescription, filterable: false,
                template: function (dataItem) {
                    return dataItem.tableDescription;
                }
            }
        ];
    };

    return extraColumns;
});