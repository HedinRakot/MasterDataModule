﻿define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        urlRoot: 'api/WebServiceMonitor',
        fields: {
            id: { type: "number", editable: false }
			, name: {
                type: "string",
                editable: false
			}
           , attempt: {
                type: "int?",
                editable: false
           }
           , checkStatus: {
               type: "int",
               editable: false
           }
           , checkDate: {
               type: "DateTime?",
               editable: false
           }
           , message: {
               type: "string",
               editable: false
           }
           , wsdlPath: {
                type: "string",
                editable: false
            }
			
        },
        
    });
    return model;
});