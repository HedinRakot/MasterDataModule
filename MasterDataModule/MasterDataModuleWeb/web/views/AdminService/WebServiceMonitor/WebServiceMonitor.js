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
                { field: "name", title: this.resources.name, width: '150px' },
                {
                    field: "checkStatus",
                    title: this.resources.checkStatus,
                    attributes: {style:"text-align:center"},
                    template: function (dataItem) {
                        var image =
                        (dataItem.checkStatus == 1) ? "success.png" : "fail.png";
                        return "<img src='../css/images/" + image + "' width='20' height='20'></img>";
                    }
                },
                {
                    field: "checkDate", title: this.resources.checkDate,
                    template: "#= kendo.toString(kendo.parseDate(checkDate, 'yyyy-MM-ddTHH:mm:ss'), 'MM.dd.yyyy HH:mm:ss') #"
                    
                },
                { field: "attempt", title: this.resources.attempt },
                { field: "message", title: this.resources.message }
            ];
        }
    });

    return view;
});