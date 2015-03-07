/// <reference path="OrganizationalUnits.js" />
define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/OrganizationalUnits',
    'l!t!CommonMasterData/Org/OrganizationalUnits/FilterOrganizationalUnits'
], function (BaseView, Collection, FilterView, DetailView) {
    'use strict';

    var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'orgOrganizationalUnit',
        editUrl: '#OrgOrganizationalUnits',

        editItemTitle: function () {
            return this.resources.edit;
        },

        columns: function () {
            return [
                { field: 'orgNumber', title: this.resources.orgNumber, width: '200px' },
		        { field: 'name',  title: this.resources.name, width: '200px' },
                //{ field: 'orgTypeId', title: this.resources.orgTypeId, width: '100px' },
		        { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' }
            ];
        }
    });

    return view;
});