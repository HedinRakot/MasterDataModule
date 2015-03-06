define([
	'base/base-filter-view',
], function (BaseView) {
	'use strict';

	var view = BaseView.extend({
        
		getFilters: function () {

		    var result = [],
                fromDate = this.model.get('fromDate'),
                toDate = this.model.get('toDate');

		    result.push({
		        field: 'fromDate',
		        operator: 'lte',
		        value: fromDate
		    });

		    result.push({
		        field: 'toDate',
		        operator: 'gte',
		        value: toDate
		    });

		    result.push({
		        field: 'name',
		        operator: 'contains',
		        value: this.model.get('name')
		    });
            
		    return result;
		},

		render: function () {

		    var self = this;
		    view.__super__.render.apply(self, arguments);

            
		    var bindings = {
		        '#fromDate': 'fromDate',
		        '#toDate': 'toDate',
		        '#name': 'name'
		    };

		    self.stickit(self.model, bindings);

		    return self;
		}
	});

	return view;
});