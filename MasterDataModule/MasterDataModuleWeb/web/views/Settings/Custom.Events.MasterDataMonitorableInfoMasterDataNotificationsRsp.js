define([

], function () {
    'use strict';

    var events = {
        'click .select-monitorable-object a': function (e) {
            e.preventDefault();

            var self = this,
                dataItem = self.grid.dataItem($(e.target).closest('tr'));

            require(['models/settings/MasterDataMonitorableInfoMasterDataNotificationsRsp', 't!Settings/SelectMonitorableObject'], function (Model, View) {
                var view = new View({ model: new Model({ id: dataItem.id }) }); debugger;
                view.options.checkModuleType = self.options.checkModuleType;

                self.listenTo(view, 'saveEvent', function (item) {
                    self.grid.dataSource.read();
                    self.grid.refresh();
                });

                self.addView(view);
                self.$el.append(view.render().$el);
            });
        }
    };

    return events;
});