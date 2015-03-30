define([	
    'base/related-object-grid-view',
'collections/Settings/SysColumns',
'l!t!Settings/AddSysColumn',
'Settings/Custom.SysColumn'
], function (BaseView, Collection, AddNewModelView, CustomColumns) {
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
		   
		   return $.merge( CustomColumns(),
[
				{ field: 'readOnly', title: this.resources.readOnly , headerTitle: this.resources.readOnly, checkbox: true},
			]);
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.sysTableId = self.model.id;

				if (e.model.isNew()) {
                    var dt = new Date(2070, 11, 31);
		            e.model.toDate = dt;
		            var numeric = e.container.find("input[name=toDate]");
		            numeric[0].value = dt.toLocaleDateString();
		        }
		    });

		    return self;
		}
	});

	return view;
});
