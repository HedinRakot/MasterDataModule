define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        urlRoot: 'api/MasterDataSiteInfos',
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
            sitePath: {
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