define([
	'base/related-object-grid-view',
    'collections/CommonMasterData/Product/InsCoreDataProductLocalizations',
    'l!t!CommonMasterData/Product/AddInsCoreDataProductLocalization'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.grid',
		tableName: 'InsCoreDataProductLocalizations',
        
        addingInPopup: false,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'insCoreDataProductId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
		    return [
				{ field: 'sysLanguageId', title: this.resources.sysLanguageId , collection: this.options.sysLanguage, defaultText: this.resources.pleaseSelect},
				{ field: 'productName', title: this.resources.productName },
				{ field: 'description', title: this.resources.description },
				{ field: 'fromDate', title: this.resources.fromDate , format: '{0:d}'},
				{ field: 'toDate', title: this.resources.toDate , format: '{0:d}'},
			];
		},
		
		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.insCoreDataProductId = self.model.id;
		    });

		    return self;
		}
	});

	return view;
});
