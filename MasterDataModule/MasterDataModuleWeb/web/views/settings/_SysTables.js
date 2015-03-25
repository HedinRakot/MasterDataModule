define([
	'base/base-grid-view',
    'l!t!settings/FilterSysTables',
	'collections/settings/sysTables',
    'l!t!settings/sysColumns'
], function (BaseView, FilterView, SysTableCollection, DetailView) {
	'use strict';

	var view = BaseView.extend({
	    gridSelector: '.tables-container',

		showAddButton: false,
		showDeleteButton: false,
		detailView: DetailView,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.collection = new SysTableCollection();
		},

		columns: function () {
		    return [
				{ field: "description", title: this.resources.name },
				{ field: "editMode", title: this.resources.edit, collection: this.options.editModeTypes },
			]
		},

		close: function () {

		},

		render: function () {
		    view.__super__.render.apply(this, arguments);

		    var filterView = new FilterView({ grid: this.grid });
		    this.showView(filterView, '.filter');

		    return this;
		},
	});

	return view;
});