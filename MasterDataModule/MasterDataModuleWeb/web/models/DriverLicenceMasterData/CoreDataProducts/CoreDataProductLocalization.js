define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        fields: {
            coreDataProductId: { type: "number", editable: false },
            sysLanguageId: { type: "number", editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'sysLanguageId'), validation: { required: true } },
            name: { type: "string", editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'name'), validation: { required: true, maxLength: 250 } },
            description: { type: "string", editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'description'), validation: { required: true, maxLength: 250 } },
            fromDate: { type: "date", editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'fromDate'), validation: { required: true } },
            toDate: { type: "date", editable: Application.canTableItemBeEdit('coreDataProductLocalization', 'toDate'), validation: { required: true } },
        }
    });

    return model;
});