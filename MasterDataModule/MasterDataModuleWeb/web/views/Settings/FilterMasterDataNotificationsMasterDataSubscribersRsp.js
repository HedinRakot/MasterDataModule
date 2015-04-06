define([
	'base/base-object-filter-view',
	'models/Settings/FilterMasterDataNotificationsMasterDataSubscribersRsp'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({

        filter: Filter
    });

    return view;
});
