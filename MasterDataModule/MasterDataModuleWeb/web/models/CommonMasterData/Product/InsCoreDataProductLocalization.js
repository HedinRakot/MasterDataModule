define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        fields: {
            insCoreDataProductId: { type: "number", editable: false },
            sysLanguageId: { type: "number", editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'sysLanguageId'), validation: { required: true } },
            name: { type: "string", editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'name'), validation: { required: true, maxLength: 250 } },
            description: { type: "string", editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'description'), validation: { required: true, maxLength: 250 } },
            fromDate: { type: "date", editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'fromDate'), validation: { required: true } },
            toDate: { type: "date", editable: Application.canTableItemBeEdit('insCoreDataProductLocalization', 'toDate'), validation: { required: true } },
        }
    });

    return model;
});