define([
	'base/base-grid-view',
	'collections/AdminService/JobStatuses'
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

        events: {
            'click .select-monitorable-object a': function (e) {
                e.preventDefault();
                var self = this,
                dataItem = self.grid.dataItem($(e.target).closest('tr'));
                location.href = '/#LogTypeInfos' + '/' + dataItem.logTypeInfoId;
            }
        },

        columns: function () {
            return [
                { field: "name", title: this.resources.name, width: 200 },
                { field: "jobName", title: this.resources.jobName, width: 200 },
                {
                    field: "checkStatus",
                    width: 50,
                    title: this.resources.checkStatus,
                    attributes: { style: "text-align:center" },
                    template: function (dataItem) {
                        var image =
                        (dataItem.checkStatus == 1) ? "success.png" : "fail.png";
                        return "<img src='../css/images/" + image + "' width='20' height='20'></img>";
                    }
                },
                {
                    field: "checkDate",
                    title: this.resources.checkDate,
                    width: 150,
                    template: "#= kendo.toString(kendo.parseDate(checkDate, 'yyyy-MM-ddTHH:mm:ss'), 'MM.dd.yyyy HH:mm:ss') #"

                },
                {
                    field: "lastRunTime",
                    title: this.resources.lastRunTime,
                    width: 150,
                    template: "#= kendo.toString(kendo.parseDate(lastRunTime, 'yyyy-MM-ddTHH:mm:ss'), 'MM.dd.yyyy HH:mm:ss') #"

                },
                {
                    title: this.resources.logRef,
                    attributes: { 'class': 'select-monitorable-object' },
                    command: { name: 'select-monitorable-object', text: this.resources.logButton }
                }
            ];
        }
    });

    return view;
});