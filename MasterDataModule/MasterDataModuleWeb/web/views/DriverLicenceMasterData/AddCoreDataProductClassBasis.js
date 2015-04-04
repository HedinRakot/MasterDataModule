define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/CoreDataProductClassBasisRelationships'
], function (BaseView, TabView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'CoreDataProductClassBasis',
        actionUrl: '#CoreDataProductClassBases',

		bindings: function () {

            var self = this;
            var result = {
			'#examClassId': { observe: 'examClassId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.examClass
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#coreDataProductId': 'coreDataProductId',
			'#legalBasisId': { observe: 'legalBasisId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.legalBasis
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#sortOrder': 'sortOrder',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examClassId', 'select');
			this.disableInput(this, 'coreDataProductId', 'numeric');
			this.disableInput(this, 'legalBasisId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'sortOrder', 'numeric');

            return this;
        }
    });

    return view;
});
