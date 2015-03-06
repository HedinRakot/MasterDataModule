define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        fields: {
            coreDataProductId: { type: "number", editable: false },
            examClassId: { type: "number", editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'examClassId'), validation: { required: true } },
            legalBasisId: { type: "number", editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'examClassId'), validation: { required: true } },
            fromDate: { type: "date", editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'legalBasisId'), validation: { required: true } },
            toDate: { type: "date", editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'toDate'), validation: { required: true } },
            sortOrder: { type: "number", editable: Application.canTableItemBeEdit('coreDataProductClassBasis', 'sortOrder') },
        }
    });

    return model;
});