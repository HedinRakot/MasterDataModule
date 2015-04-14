﻿define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        urlRoot: 'api/JobMonitor',
        fields: {
            id: { type: "number", editable: false }
			, name: {
                type: "string",
                editable: false
			}
           , jobName: {
                type: "string",
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
           , lastRunTime: {
               type: "DateTime?",
               editable: false
           }
        
        }
        
    });
    return model;
});