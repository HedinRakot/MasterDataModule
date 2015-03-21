define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/CoreDataProductRelationships',
    'l!t!DriverLicenceMasterData/SelectProduct'
], function (BaseView, TabView, SelectProductView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'CoreDataProduct',
        actionUrl: '#CoreDataProducts',

		bindings: function () {

            var self = this;
            var result = {
			'#insCoreDataProductId': 'insCoreDataProductId',
			'#insCoreDataProductId_Name': 'insCoreDataProductName',
			'#minAge': 'minAge',
			'#maxAge': 'maxAge',
			'#examType': { observe: 'examType',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.examType
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#priorTimeInMonths': 'priorTimeInMonths',
			'#expirationInMonth': 'expirationInMonth',
			'#repeatTimeInDays': 'repeatTimeInDays',
			'#trainingCertFlag': 'trainingCertFlag',
			'#resultFlag': 'resultFlag',
			'#multiplyFlag': 'multiplyFlag',
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			'#isMofaPrint': 'isMofaPrint',
			'#isAdditionalProduct': 'isAdditionalProduct',
			'#isPrepaymentRequired': 'isPrepaymentRequired',
			'#isMandatory': 'isMandatory',
			'#feProductNumber': 'feProductNumber',
			'#repeatTimeInDaysReduced': 'repeatTimeInDaysReduced',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'minAge', 'numeric');
			this.disableInput(this, 'maxAge', 'numeric');
			this.disableInput(this, 'examType', 'select');
			this.disableInput(this, 'priorTimeInMonths', 'numeric');
			this.disableInput(this, 'expirationInMonth', 'numeric');
			this.disableInput(this, 'repeatTimeInDays', 'numeric');
			this.disableInput(this, 'trainingCertFlag');
			this.disableInput(this, 'resultFlag');
			this.disableInput(this, 'multiplyFlag');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');
			this.disableInput(this, 'isMofaPrint');
			this.disableInput(this, 'isAdditionalProduct');
			this.disableInput(this, 'isPrepaymentRequired');
			this.disableInput(this, 'isMandatory');
			this.disableInput(this, 'feProductNumber');
			this.disableInput(this, 'repeatTimeInDaysReduced', 'numeric');

            return this;
        }
		,events: {
			'click .SelectProduct': function (e) {
                e.preventDefault();

                var self = this,
                    view = new SelectProductView();

                self.listenTo(view, 'select', function (item) {

                    self.model.set('insCoreDataProductId', item.id);
                    self.$el.find('#insCoreDataProductId').val(item.id);
                    self.$el.find('#insCoreDataProductId_Name').val(item.get('productName'));
                });

                self.addView(view);
                self.$el.append(view.render().$el);
            },
		}
    });

    return view;
});
