define([
	'base/base-object-add-view',
    'l!t!Settings/MasterDataWcfCheckResultsRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'MasterDataWcfCheckResults',
        actionUrl: '#MasterDataWcfCheckResults',

		bindings: function () {

            var self = this;
            var result = {
			'#checkStatus': 'checkStatus',
			'#checkDate': 'checkDate',
			'#message': 'message',
			'#attempt': 'attempt',
			'#masterDataWcfInfoId': 'masterDataWcfInfoId',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'checkStatus', 'numeric');
			this.disableInput(this, 'checkDate', 'date');
			this.disableInput(this, 'message');
			this.disableInput(this, 'attempt', 'numeric');
			this.disableInput(this, 'masterDataWcfInfoId', 'numeric');

            return this;
        }
    });

    return view;
});
