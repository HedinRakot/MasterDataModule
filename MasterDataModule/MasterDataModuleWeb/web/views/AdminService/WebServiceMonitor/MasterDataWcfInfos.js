define([
'base/base-grid-view',
'collections/AdminService/MasterDataWcfInfos'

], function (BaseView, Collection) {
    'use strict';

    var view = BaseView.extend({

        gridSelector: 'div',

        showAddButton: true,
        showDeleteButton: true,
        showEditButton: true,

        defautSorting: {
            field: 'name',
            dir: 'desc'
        },

        initialize: function () {
            view.__super__.initialize.apply(this, arguments);

            this.collection = new Collection();
        },

        columns: function () {

            return [
				{ field: 'name', title: this.resources.name },
				{ field: 'wsdlPath', title: this.resources.wsdlPath },
				{ field: 'timeoutChecking', title: this.resources.timeoutChecking }
				
            ];
        }

    });

    return view;
});
