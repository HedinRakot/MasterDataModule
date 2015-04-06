define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataMonitorStateRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataMonitorState',
        actionUrl: '#MasterDataMonitorStates',

		bindings: function () {

            var self = this;
            var result = {
			'#reconfigure': 'reconfigure',
			'#reconfigureCheckingTimeout': 'reconfigureCheckingTimeout',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'reconfigure');
			this.disableInput(this, 'reconfigureCheckingTimeout', 'numeric');

            return this;
        }
    });

    return view;
});
