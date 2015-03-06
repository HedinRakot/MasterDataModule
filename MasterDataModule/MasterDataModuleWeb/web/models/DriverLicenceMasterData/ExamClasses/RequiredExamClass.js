define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        fields: {
            examClassId: { type: "number", editable: false },
            requiredExamClassId: { type: "number", editable: Application.canTableItemBeEdit('requiredExamClass', 'requiredExamClassId'), validation: { required: true } },
            fromDate: { type: "date", editable: Application.canTableItemBeEdit('requiredExamClass', 'fromDate'), validation: { required: true } },
            toDate: { type: "date", editable: Application.canTableItemBeEdit('requiredExamClass', 'toDate'), validation: { required: true } },
        }
    });

    return model;
});