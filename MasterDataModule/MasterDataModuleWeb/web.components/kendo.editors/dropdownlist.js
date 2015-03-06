define([
	'kendo/kendo.dropdownlist'
], function () {
    'use strict';

    var editor = function (container, options) {
        $('<select />').appendTo(container).attr('name', options.field).kendoDropDownList({
            dataSource: options.values,
            dataTextField: 'text',
            dataValueField: 'value',
            valuePrimitive: true
        });
    };

    return editor;
});