define([
	'base/base-object-add-view',
    'l!t!Settings/SysTableRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'SysTable',
        actionUrl: '#SysTables',

		bindings: function () {

            var self = this;
            var result = {
			'#description': 'description',
			'#editMode': { observe: 'editMode',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.editModeType
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'description');
			this.disableInput(this, 'editMode', 'select');

            return this;
        }
    });

    return view;
});
