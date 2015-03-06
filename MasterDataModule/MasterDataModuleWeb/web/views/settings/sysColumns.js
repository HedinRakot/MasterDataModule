define([
	'base/base-grid-view',
	'collections/settings/sysColumns'
], function (BaseView, SysColumnCollection) {
	'use strict';

	var view = BaseView.extend({
		gridSelector: 'div',

		showAddButton: false,
		showDeleteButton: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'sysTableId', operator: 'eq', value: this.options.model.id };

			this.collection = new SysColumnCollection();
		},

		columns: function () {
		    return [
				{ field: "description", title: this.resources.name },
                {
                    field: "readOnly",
                    title: this.resources.edit,
                    headerTitle: this.resources.editTitle,
                    checkbox: true
                }
			]
		}
	});

	return view;
});