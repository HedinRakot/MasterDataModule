define([
	'base/base-object-add-view',
    'l!t!DriverLicenceMasterData/CoreDataProducts/CoreDataProductsRelationships',
    'l!t!DriverLicenceMasterData/CoreDataProducts/SelectProduct',
], function (BaseView, TabView, SelectProductView) {
    'use strict';

    var view = BaseView.extend({

        tabView: TabView,
        tableName: 'coreDataProduct',
        actionUrl: '#CoreDataProducts',

        bindings: {
            '#name': 'name',
            '#description': 'description',
            '#fromDate': 'fromDate',
            '#toDate': 'toDate',
            '#minAge': 'minAge',
            '#maxAge': 'maxAge',
            '#examType': 'examType',
            '#insCoreDataProductId': 'insCoreDataProductId',
            '#insCoreDataProductName': 'insCoreDataProductName',
            '#priorTimeInMonths': 'priorTimeInMonths',
            '#repeatTimeInDays': 'repeatTimeInDays',
            '#repeatTimeInDaysReduced': 'repeatTimeInDaysReduced',
            '#trainingCertFlag': 'trainingCertFlag',
            '#resultFlag': 'resultFlag',
            '#multiplyFlag': 'multiplyFlag',
            '#isMofaPrint': 'isMofaPrint',
            '#isAdditionalProduct': 'isAdditionalProduct',
            '#isPrepaymentRequired': 'isPrepaymentRequired',
            '#isMandatory': 'isMandatory',


            '.name-container': {
                observe: 'id',
                updateView: true,
                update: function ($el, value) {
                    if (!value)
                        return;

                    var self = this;
                    self.$el.find('#name').attr('disabled', true);
                    self.$el.find('#description').attr('disabled', true);
                }
            },
        },

        render: function () {

            this.disableInput(this, 'name');
            this.disableInput(this, 'description');

            view.__super__.render.apply(this, arguments);
            
            //TODO foreach model field

            this.disableInput(this, 'fromDate', 'date');
            this.disableInput(this, 'toDate', 'date'); 
            this.disableInput(this, 'minAge', 'numeric');
            this.disableInput(this, 'maxAge', 'numeric');
            this.disableInput(this, 'examType');
            this.disableInput(this, 'priorTimeInMonths', 'numeric');
            this.disableInput(this, 'repeatTimeInDays', 'numeric');
            this.disableInput(this, 'repeatTimeInDaysReduced', 'numeric');
            this.disableInput(this, 'trainingCertFlag');
            this.disableInput(this, 'resultFlag');
            this.disableInput(this, 'multiplyFlag');
            this.disableInput(this, 'isMofaPrint');
            this.disableInput(this, 'isAdditionalProduct');
            this.disableInput(this, 'isPrepaymentRequired');
            this.disableInput(this, 'isMandatory');

            //todo disable select button

            return this;
        },

        events: {
            'click .selectProduct': function (e) {
                e.preventDefault();

                var self = this,
					view = new SelectProductView();

                self.listenTo(view, 'select', function (coreDataProduct) {

                    self.model.set('insCoreDataProductId', coreDataProduct.id);
                    self.$el.find('#insCoreDataProductId').val(coreDataProduct.id);
                    self.$el.find('#insCoreDataProductName').val(coreDataProduct.get('name'));
                });

                self.addView(view);
                self.$el.append(view.render().$el);
            }
        },
    });

    return view;
});