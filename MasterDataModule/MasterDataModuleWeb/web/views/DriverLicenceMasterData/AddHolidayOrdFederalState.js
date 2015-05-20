define([
	'base/base-object-add-view',
    
], function (BaseView ) {
    'use strict';

    var view = BaseView.extend({

        
        tableName: 'HolidayOrdFederalState',
        actionUrl: '#HolidayOrdFederalStates',

		bindings: function () {

            var self = this;
            var result = {
			'#holidayId': 'holidayId',
			'#ordFederalStateId': { observe: 'ordFederalStateId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.ordFederalState
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'holidayId', 'numeric');
			this.disableInput(this, 'ordFederalStateId', 'select');

            return this;
        }
    });

    return view;
});
