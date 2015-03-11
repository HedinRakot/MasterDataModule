define([
	'base/base-object-add-view',
    'l!t!CommonMasterData/Employee/EmpOrgAssociationTypeRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'EmpOrgAssociationType',
        actionUrl: '#EmpOrgAssociationTypes',

		bindings: {
			'#name': 'name',
			'#description': 'description',
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'name');
			this.disableInput(this, 'description');

            return this;
        }
    });

    return view;
});
