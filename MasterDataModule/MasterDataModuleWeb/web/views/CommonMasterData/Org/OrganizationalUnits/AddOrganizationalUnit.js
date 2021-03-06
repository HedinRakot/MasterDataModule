﻿define([
	'base/base-object-add-view'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({
        tabView: TabView,
        tableName: 'orgOrganizationalUnit',
        actionUrl: '#OrgOrganizationalUnits',

        bindings: function() {
            return {
                '#name': 'name',
                '#orgNumber': 'orgNumber',
                '#fromDate': 'fromDate',
                '#toDate': 'toDate',
                '#abbr': 'abbr',
                '#locationAbbr': 'locationAbbr',
                '#emailFrom': 'emailFrom',
                '#emailTo': 'emailTo',
                '#isEgdokPrintAlways': 'isEgdokPrintAlways',
                '#orgAccountingArea': {
                    observe: 'orgAccountingAreaId',
                    selectOptions: {
                        labelPath: 'accountingArea',
                        valuePath: 'id',
                        collection: this.options.accountingAreas,
                        defaultOption: {
                            label: 'None',
                            value: null
                        }
                    }
                },
                '#orgTypeId': {
                    observe: 'orgTypeId',
                    selectOptions: {
                        labelPath: 'name',
                        valuePath: 'id',
                        collection: this.options.orgTypes,
                        defaultOption: {
                            label: 'None',
                            value: null
                        }
                    }
                }

            }
        },

        render: function () {
            view.__super__.render.apply(this, arguments);
            return this;
        }
    });

    return view;
});