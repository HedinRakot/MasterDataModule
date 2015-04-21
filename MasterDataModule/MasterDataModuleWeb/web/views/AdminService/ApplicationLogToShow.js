define([
	'base/base-grid-view',
	'collections/AdminService/ApplicationLogsToShow'
], function (BaseView, Collection) {
    'use strict';

    var view = BaseView.extend({
        gridSelector: 'div',

        showAddButton: false,
        showDeleteButton: false,
        showEditButton: false,

        defautSorting: {
            field: 'messageDate',
            dir: 'desc'
        },

        initialize: function () {
            view.__super__.initialize.apply(this, arguments);
            
            var self = this;
            this.defaultFiltering = { field: 'logTypeInfoId', operator: 'eq', value: self.options.logTypeId };

            this.collection = new Collection();
        },
        
      
        columns: function() {
            return [
                { field: "fileName", title: this.resources.fileName, width: 200 },
                { field: "logLevel", title: this.resources.logLevel, width: 50 },
                
                {
                    field: "messageDate",
                    title: this.resources.messageDate,
                    width: 150,
                    template: "#= kendo.toString(kendo.parseDate(messageDate, 'yyyy-MM-ddTHH:mm:ss'), 'MM.dd.yyyy HH:mm:ss') #"

                },
                { field: "message", title: this.resources.message, width: 500 }
            ];
        }
    });

    return view;
});