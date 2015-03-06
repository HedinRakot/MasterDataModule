define([
	'base/base-object-add-view',
	'l!t!DriverLicenceMasterData/ReturnReasons/ReturnReasonsRelationships'
], function (BaseView, TabView) {
	'use strict';

	var view = BaseView.extend({

		tabView: TabView,
		tableName: 'returnReason',
		actionUrl: '#ReturnReasons',

		bindings: function () {

			return {
				'#name': 'name',
				'#description': 'description',
				'#text1': 'text1',
				'#text2': 'text2',
				'#fromDate': 'fromDate',
				'#toDate': 'toDate',
			};
		},

		render: function () {

			view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

			return this;
		}
	});

	return view;
});