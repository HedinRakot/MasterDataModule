define([
	'base/related-object-grid-view',
	'collections/DriverLicenceMasterData/CoreDataProductClassBases',
], function (BaseView, Collection) {
	'use strict';

	var view = BaseView.extend({

		collectionType: Collection,
		gridSelector: '.products',
		tableName: 'coreDataProductClassBases',

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'examClassId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
			return [
				{
				    field: 'coreDataProductId', title: this.resources.coreDataProduct,
				    collection: this.options.coreDataProduct, filterable: false,
				},
                {
                    field: 'legalBasisId', title: this.resources.legalBasis,
                    collection: this.options.legalBasis, filterable: false,
                },
                { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
		        { field: 'sortOrder', title: this.resources.sortOrder },
			];
		},

		toolbar: function () {

		    var self = this;

		    if (Application.canTableItemBeCreated(self.tableName)) {
		        var result = [
                    {
                        template: function () {
                            return '<a class="k-button" href="#CoreDataProducts/create' + /*self.model.id + */
                                '">' + self.resources.newProduct + '<a/>';
                        }
                    }
		        ];

		        return result;
		    }
		},

		render: function () {
		    var self = this;

		    self.showAddButton = false;
		    self.showDeleteButton = false;
		    self.showEditButton = false;

		    view.__super__.render.apply(self, arguments);
            
		    return self;
		},
	});

	return view;
});