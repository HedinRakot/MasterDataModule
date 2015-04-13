define([
	'lr!resources/Settings/Custom.SysColumns',
], function (Resources) {
    'use strict';

    var extraColumns = function () {
        return [
            {
                title: Resources.columnDescription, filterable: false,
                template: function (dataItem) {
                    return dataItem.columnDescription;
                }
            }
        ];
    };

    return extraColumns;
});