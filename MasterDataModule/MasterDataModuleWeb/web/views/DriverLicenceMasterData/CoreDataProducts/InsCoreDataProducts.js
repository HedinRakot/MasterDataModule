define([
	'base/base-grid-view',
    'collections/DriverLicenceMasterData/InsCoreDataProducts',
    'l!t!DriverLicenceMasterData/CoreDataProducts/FilterInsCoreDataProducts'
], function (BaseView, Collection, FilterView) {
	'use strict';

	var saveFunction = function (e, self) {
	    e.preventDefault();

	    var grid = self.grid,
            dataItem = grid.dataItem(grid.select()),
            model = dataItem ? self.collection.get(dataItem.id) : null;

	    if (model)
	        self.options.success(model);
	    else
	        self.$('.product-select-message').show();
	},


    view = BaseView.extend({

        collectionType: Collection,
        filterView: FilterView,
        filterSelector: '.filter',

        showDeleteButton: false,
        showEditButton: false,
        showAddButton: false,

        selectable: true,
        pageSizes: null,
        gridSelector: '.grid',

        initialize: function () {
            view.__super__.initialize.apply(this, arguments);

            this.collection = new Collection();
        },

        render: function () {

            var self = this;
            view.__super__.render.apply(self, arguments);

            self.showView(new self.filterView({ grid: self.grid }),
                self.filterSelector);

            return self;
        },

		columns: function () {
		    return [
		        { field: 'name', title: this.resources.name, width: '270px' },
		        { field: 'description', title: this.resources.description },
		        { field: 'productNumber', title: this.resources.productNumber, width: '220px' },
		        { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
		    ];
		},

		events: {
		    'dblclick .k-grid tbody tr': function (e) {
		        saveFunction(e, this);
		    },
		    'click .select': function (e) {
		        saveFunction(e, this);
		    },
		    'click .cancel': function (e) {
		        e.preventDefault();

		        this.options.cancel();
		    }
		},

		toolbar: function () {
		    var self = this;
		    return [
				{ template: function () { return '<a class="k-button k-primary select" href="#">' + 
                    self.resources.select + '</a>'
				}
				},
        		{ template: function () { return '<a class="k-button cancel" href="#">' + self.resources.cancel + '</a>' } },
        		{ template: function () { return '<span class="product-select-message k-widget k-tooltip k-tooltip-validation k-invalid-msg"><span class="k-icon k-warning"></span>' + self.resources.noSelectionMessage + '</span>' } }
		    ];
		}
	});

	return view;
});