define([
	'base/base-object-filter-view',
	'models/DriverLicenceMasterData/ReturnReasons/FilterReturnReason'
], function (BaseFilterView, Filter) {
    'use strict';

    var view = BaseFilterView.extend({

        filter: Filter,

        //bindings: {
        //    '#description': 'description'
        //},

        //getFilters: function () {

        //    var baseFilters = view.__super__.getFilters.apply(this, arguments);

        //    baseFilters.push({
        //        field: 'description',
        //        operator: 'contains',
        //        value: this.model.get('description')
        //    });

        //    return baseFilters;
        //}
    });

    return view;
});