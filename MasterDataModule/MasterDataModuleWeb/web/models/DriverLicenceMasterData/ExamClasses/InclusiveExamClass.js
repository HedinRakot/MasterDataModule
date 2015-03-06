define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        fields: {
            examClassId: { type: "number", editable: false },
            inclusiveExamClassId: { type: "number", editable: Application.canTableItemBeEdit('inclusiveExamClass', 'inclusiveExamClassId'), validation: { required: true } },
            fromDate: { type: "date", editable: Application.canTableItemBeEdit('inclusiveExamClass', 'fromDate'), validation: { required: true } },
            toDate: { type: "date", editable: Application.canTableItemBeEdit('inclusiveExamClass', 'toDate'), validation: { required: true } },
            isConditional: { type: "boolean", editable: Application.canTableItemBeEdit('inclusiveExamClass', 'isConditional') },
        }
    });

    return model;
});