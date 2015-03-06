define([
	'base/related-object-grid-view',
	'collections/DriverLicenceMasterData/CoreDataProductLocalizations'
], function (BaseView, Collection) {
	'use strict';

	var view = BaseView.extend({
		
	    collectionType: Collection,
		gridSelector: '.localizations',
		tableName: 'coreDataProductLocalization',

		addNewModelInline: function() {
		    
		    return { coreDataProductId: this.options.parentId, sysLanguageId: null };
		},

		initialize: function () {

			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'coreDataProductId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {

		    return [
                { field: 'name', title: this.resources.name },
                { field: 'description', title: this.resources.description },
				{
				    field: 'sysLanguageId', title: this.resources.sysLanguage,
				    collection: this.options.sysLanguages,
				    defaultText: 'Sprache auswählen',
				    filterable: false
				},
                { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
			];
		},

		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {

		        e.model.coreDataProductId = self.model.id;
		    });

		    return self;
		},

	});

	return view;
});