define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        urlRoot: 'api/OrgOrganizationalUnit',
        fields: {
            id: { type: "number", editable: false },
            orgNumber: { type: "number", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'orgNumber') },
            name: { type: "string", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'name') },
            abbr: { type: "string", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'abbr') },
            orgTypeId: { type: "number", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'orgTypeId') },
            locationAbbr: { type: "string", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'locationAbbr') },
            sysLocationId: { type: "number", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'sysLocationId') },
            emailFrom: { type: "string", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'emailFrom') },
            emailTo: { type: "string", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'emailTo') },
            isEgdokPrintAlways: { type: "boolean", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'isEgdokPrintAlways') },
            deleteDate: { type: "DateTime", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'deleteDate') },
            source: { type: "string", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'source') },
            orgAccountingAreaId: { type: "number", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'orgAccountingAreaId') },
            fromDate: { type: "date", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'fromDate'), validation: { required: true, date: true } },
            toDate: { type: "date", editable: Application.canTableItemBeEdit('orgOrganizationalUnit', 'toDate'), validation: { required: true, date: true } },
        }
    });

    return model;
});