define([
    'base/base-view',
    'kendo.backbone/backbone.datasource',
    'collections/Settings/MasterDataWcfInfos',
    'collections/Settings/MasterDataSiteInfos',
    'collections/Settings/MasterDataWindowsServiceInfos',
    'collections/Settings/MasterDataJobInfos',
    'jquerySignalR',
    'signalrHubs',
	'lk!kendo/kendo.grid'
], function (BaseView, DataSource, WcfInfos, SiteInfos, WindowsServiceInfos, JobInfos) {
    'use strict';

    var getSelectorForImage = function (type, id) {
        return 'href_' + type.toString() + '_' + id.toString();
    }

    var fillInfos = function(selector, type, collection, view, href) {
        var col = new collection();
        col.fetch().done(function (result) {
            $.each(result.data, function (index, item) {
                view.$('#' + selector).append("<tr><td><img id='" + getSelectorForImage(type, item.id) + "' src='../../css/images/" + "Circle_Grey.png" + "' width='20' height='20'/></td><td><a href = '#" + href + "'>" + item.name + "</a></td></tr>");
            });
        });
    }

    var view = BaseView.extend({
        initialize: function() {
            view.__super__.initialize.apply(this, arguments);

            var hub = $.connection.monitorableObjects;
            hub.client.statusChanged = function (checkModuleType, infoId, result) {
                var selector = getSelectorForImage(checkModuleType, infoId);
                var image = result === 1 ? "Circle_Green.png" : "Circle_Red.png";
                $('#' + selector).attr('src', "../../css/images/" + image);
            };

            fillInfos('wcfServices', 1, WcfInfos, this, 'WebServiceMonitor');
            fillInfos('sites', 2, SiteInfos, this, 'WebSiteMonitor');
            fillInfos('windowsServices', 4, WindowsServiceInfos, this, 'WinServiceMonitor');
            fillInfos('jobs', 3, JobInfos, this, 'JobMonitor');

            $.connection.hub.start();
        }
    });




    return view;
});