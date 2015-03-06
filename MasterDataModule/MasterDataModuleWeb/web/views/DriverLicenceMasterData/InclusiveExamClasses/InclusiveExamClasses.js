define([
	'base/related-object-grid-view',
	'collections/DriverLicenceMasterData/InclusiveExamClasses',
	'l!t!DriverLicenceMasterData/InclusiveExamClasses/AddInclusiveExamClass'
], function (BaseView, Collection, AddNewModelView) {
	'use strict';

	var view = BaseView.extend({

		addNewModelView: AddNewModelView,
		collectionType: Collection,
		gridSelector: '.inclusive-classes',
		tableName: 'inclusiveExamClass',
        
        addingInPopup: true,

		initialize: function() {
			view.__super__.initialize.apply(this, arguments);

			this.defaultFiltering = { field: 'examClassId', operator: 'eq', value: this.model.id };

			this.collection = new Collection();
		},

		columns: function () {
			return [
				{
				    field: 'inclusiveExamClassId', title: this.resources.inclusiveExamClass,
				    collection: this.options.examClasses, filterable: false
				},
                { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' }, 
                {
                    field: "isConditional",
                    title: this.resources.isConditional,
                    headerTitle: this.resources.isConditionalTitle,
                    checkbox: true
                }
			];
		},

		render: function () {
		    var self = this;

		    view.__super__.render.apply(self, arguments);

		    self.grid.bind('edit', function (e) {
		        e.model.examClassId = self.model.id;
		    });

		    return self;
		},
	});

	return view;
});