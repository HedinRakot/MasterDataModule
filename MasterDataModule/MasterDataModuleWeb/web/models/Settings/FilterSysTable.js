define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        fields: {
            description: { type: "string", editable: true },
        }
    });

    return model;
});