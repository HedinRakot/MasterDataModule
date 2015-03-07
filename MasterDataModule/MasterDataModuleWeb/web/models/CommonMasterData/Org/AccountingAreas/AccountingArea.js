define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        urlRoot: 'api/OrgAccountingArea',
        fields: {
            id: { type: "number", editable: false },
            accoutingArea: { type: "string", editable: false }
        }
    });

    return model;
});