define([
	'lr!resources/Settings/Custom.MasterDataMonitorableInfoMasterDataNotificationsRsp',
], function (Resources) {
    'use strict';

    var extraColumns = function () {
        return [		
            {
                attributes: { 'class': 'select-monitorable-object' },
                command: { name: 'select-monitorable-object', text: Resources.selectMonitorableObject }
            },
            {
                title: Resources.monitorableInfoType,
                template: function (dataItem) {
                    return dataItem.monitorableInfoTypeText != undefined ? dataItem.monitorableInfoTypeText : '';
                }
            },
            {
                title: Resources.monitorableInfoObject,
                template: function (dataItem) {
                    return dataItem.monitorableInfoObject != undefined ? dataItem.monitorableInfoObject : '';
                }
            }
        ];
    };

    return extraColumns;
});