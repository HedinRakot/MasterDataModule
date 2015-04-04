define([
	'base/base-grid-view',
	'collections/AdminService/WcfServiceStatuses'
], function (BaseView, Collection) {
    'use strict';

    var view = BaseView.extend({
        gridSelector: 'div',

        showAddButton: false,
        showDeleteButton: false,
        showEditButton: false,

        defautSorting: {
            field: 'checkDate',
            dir: 'desc'
        },

        initialize: function () {
            view.__super__.initialize.apply(this, arguments);

            this.collection = new Collection();
        },

        columns: function () {
            return [
                { field: "name", title: 'WCF Name', width: '150px' },
                { field: "checkStatus", title: 'Status' },
                { field: "checkDate", title: 'Datum' },
                { field: "attempt", title: 'Versuch' },
                { field: "message", title: 'Datum' }
            ];
        }
    });

    return view;
});