define([
    'base/base-view',
    'kendo.backbone/backbone.datasource',
    'collections/Settings/MasterDataSiteInfos',
    'jquerySignalR',
    'signalrHubs',
    'lr!mixins/resources/kendo-validator-form',
	'kendo.editors/editor-factory',
	'kendo.filters/filter-factory',
	'lk!kendo/kendo.grid'
], function (BaseView, DataSource, MasterDataInfos) {
    'use strict';

    var createDataSource = function(collection) {
        return new DataSource({
            collection: collection,
            schema: {
                model: {
                    id: collection.model.prototype.idAttribute,
                    fields: collection.model.prototype.fields
                },
                data: 'data',
                total: 'total'
            },
            remoteDataSource: true
        });
    };

    var getStatusTemplate = function(dataItem) {
        var image =
        (dataItem.status === 1) ? "success.png" : "fail.png";
        return "<img src='../css/images/" + image + "' width='20' height='20'></img>";
    };

    var view = BaseView.extend({
        initialize: function() {
            view.__super__.initialize.apply(this, arguments);

            var hub = $.connection.monitorableObjects;
            hub.client.statusChanged = function(message) {
                $("#messages").append("<li> " + message + " </li>");
            };

            $.connection.hub.start();
       },

        render: function() {
            view.__super__.render.apply(this, arguments);

            this.$('#siteInfosGrid').kendoGrid({
                scrollable: false,
                columns: [
                    { field: "name", title: this.resources.name },
                    { field: "status", title: this.resources.status, template: getStatusTemplate }],
                dataSource: createDataSource(new MasterDataInfos())
            });
            
            return this;
        }
    });




    return view;
});