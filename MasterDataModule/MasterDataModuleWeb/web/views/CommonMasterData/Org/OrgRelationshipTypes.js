define([
	'base/base-object-grid-view',
    'collections/CommonMasterData/Org/OrgRelationshipTypes',
    'l!t!CommonMasterData/Org/FilterOrgRelationshipType',
    'l!t!CommonMasterData/Org/OrgRelationshipTypeRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
        tableName: 'OrgRelationshipType',
        editUrl: '#OrgRelationshipTypes',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
				{ field: 'name', title: this.resources.name },
				{ field: 'description', title: this.resources.description },
			];
		}
	});

	return view;
});