define([
	'base/related-object-grid-view',
    'collections/Settings/SysColumns',
    'l!t!Settings/AddSysColumn'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'SysColumns',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'sysTableId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'sysTableId', title: this.resources.sysTableId },
				{ field: 'description', title: this.resources.description },
				{ field: 'readOnly', title: this.resources.readOnly , headerTitle: this.resources.readOnly, checkbox: true},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.sysTableId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
