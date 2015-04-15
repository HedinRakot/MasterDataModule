define([
	'base/base-object-add-view',
    'l!t!Settings/LogTypeInfoRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'LogTypeInfo',
        actionUrl: '#LogTypeInfos',

		bindings: function () {

            var self = this;
            var result = {
			'#fileName': 'fileName',
			'#filePattern': 'filePattern',
			'#filePath': 'filePath',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'fileName');
			this.disableInput(this, 'filePattern');
			this.disableInput(this, 'filePath');

            return this;
        }
    });

    return view;
});
