define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        urlRoot: 'api/ApplicationLogToShow',
        fields: {
            id: { type: "number", editable: false },
            fileName: {
                type: "string",
                editable: false
            },
            logLevel: {
                type: "int",
                editable: false
            },
            
            messageDate: {
                type: "DateTime?",
                editable: false
            },
            message: {
                type: "string",
                editable: false
            },
            logTypeInfoId: {
                type: "int?",
                editable: false
            }
        },
        
    });
    return model;
});