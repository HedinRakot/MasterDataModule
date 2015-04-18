define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        urlRoot: 'api/GetWinServicesStatuses',
        fields: {
            id: { type: "number", editable: false },
            name: {
                type: "string",
                editable: false
            },
            attempt: {
                type: "int?",
                editable: false
            },
            checkStatus: {
                type: "int",
                editable: false
            },
            checkDate: {
                type: "DateTime?",
                editable: false
            },
            message: {
                type: "string",
                editable: false
            },
            machineName: {
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