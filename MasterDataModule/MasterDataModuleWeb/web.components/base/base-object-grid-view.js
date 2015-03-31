define([
	'base/base-grid-view',
    'base/base-view'
], function (BaseView, DetailViewContainer) {
	'use strict';

    var initDetailView = function (e) {

        var self = this;

        var options = _.extend({}, self.options, { model: e.data }),
            view = new self.detailView(options);

        self.addView(view);
        e.detailRow.find('.detailsContainer').append(view.render().$el);

        var extendedView = '<a href="' + self.editUrl + '/' + e.data.id +
        '" class="gotoObjectDetail"><label>' + self.editItemTitle() + '</label>' +
        '</a><div class="relations-container"></div>';


        e.detailRow.find('.extendedDetailsContainer').append(extendedView);

        e.masterRow.data('detail-view', view);
    },

	view = BaseView.extend({

        collectionType: null,
	    
        filterView: null,
		showDeleteButton: false,
		showEditButton: false,
		showAddButton: false,
		tableName: null,
		editUrl: null,
		createNewItemTitle: 'add',
		editItemTitle: null,
	    gridSelector: '.grid',
	    filterSelector: '.filter',

	    initDetailView: initDetailView,

		toolbar: function () {

		    var self = this;

		    if (Application.canTableItemBeCreated(self.tableName)) {
		        var result = [
                    {
                        template: function () {
                            return '<a class="k-button k-button-icontext" href="' + self.editUrl +
                                '/create" data-localized="' + self.createNewItemTitle + '"></a>';
                        }
                    }
		        ];

		        return result;
		    }
		},

		events: {
		    'dblclick .k-grid tbody tr.k-master-row td:not(.k-hierarchy-cell)': function (e) {
		        
		        var self = this,
		            dataItem = self.grid.dataItem(e.currentTarget.parentElement);

		        location.href = self.editUrl + '/' + dataItem.id;
			}
		},

		initialize: function () {

			view.__super__.initialize.apply(this, arguments);

			this.collection = new this.collectionType();
		},

		render: function () {

		    var self = this;
		    view.__super__.render.apply(self, arguments);

		    self.showView(new self.filterView({ grid: self.grid }),
                self.filterSelector);

		    return self;
		},

		detailTemplate: '<div class="extendedDetailsContainer"></div><div class="detailsContainer"></div>',
	});

	return view;
});