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
				{ field: 'name', title: this.resources.name, width: 350 },
				{ field: 'wsdlPath', title: this.resources.wsdlPath, width: 350 },
				{ field: 'timeoutChecking', title: this.resources.timeoutChecking, width: 50 }
				
            ];
        }

    });

    return view;
});
