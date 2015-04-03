define([	
    'base/related-object-grid-view',
'collections/CommonMasterData/Org/OrgCostCenterPrices',
'l!t!CommonMasterData/Org/AddOrgCostCenterPrice'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'OrgCostCenterPrices',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'orgCostCenterId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		   
		   return [
				{ field: 'insCoreDataProductId', title: this.resources.insCoreDataProductId },
				{ field: 'salesOffice', title: this.resources.salesOffice },
				{ field: 'minPrice', title: this.resources.minPrice },
				{ field: 'maxPrice', title: this.resources.maxPrice },
				{ field: 'standartPrice', title: this.resources.standartPrice },
				{ field: 'quantity', title: this.resources.quantity },
				{ field: 'unitOfMeasure', title: this.resources.unitOfMeasure },
				{ field: 'sysCurrencyId', title: this.resources.sysCurrencyId },
				{ field: 'changeAbilityType', title: this.resources.changeAbilityType },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.orgCostCenterId = self.model.id;

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
