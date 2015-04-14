define([
    'base/base-view',
    'jquerySignalR',
    'signalrHubs',
    'collections/Settings/MasterDataSiteInfos',
    'kendo.backbone/backbone.datasource'
], function (BaseView, Template) {
    'use strict';

    var view = BaseView.extend({
        template: Template,

        initialize: function () {
            view.__super__.initialize.apply(this, arguments);

            var hub = $.connection.monitorableObjects;
            hub.client.statusChanged = function (message) {
                $("#messages").append("<li> " + message + " </li>");
            };

            $.connection.hub.start();
        }
    });




    return view;
});