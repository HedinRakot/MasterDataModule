define([
	'base/base-filter-view',
	'models/settings/FilterSysTable'
], function (BaseFilterView, Filter) {
    'use strict'

    var view = BaseFilterView.extend({
        filter: Filter,
        bindings: {
            '#description': 'description'
        },
        getFilters: function () {
            var result = [];

            result.push({
                field: 'description',
                operator: 'contains',
                value: this.model.get('description')
            });
            
            return result;
        }
    });

    return view;
});