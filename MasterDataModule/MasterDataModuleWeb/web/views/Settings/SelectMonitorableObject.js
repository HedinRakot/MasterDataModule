define([
	'base/base-window-view',
	'mixins/kendo-validator-form',
    'mixins/kendo-widget-form',
	'mixins/localized-view',
	'mixins/bound-form',
    'lr!resources/Settings/Custom.SelectMonitorableObject',
], function (BaseView, KendoValidatorFormMixin, KendoWidgetFormMixin, LocalizedViewMixin, BoundForm, Resources) {
	'use strict';

	var view = BaseView.extend({
		title: function () {
			return Resources.title;
		},
		events: {
			'click button[type=submit]': function (e) {
				e.preventDefault();
				var self = this;

				if (self.validate()) {
				    self.model.url = 'api/MasterDataMonitorableInfoMasterDataNotificationsRsps',
					self.model.save({
						id: self.model.id,
						monitorableInfoType: self.model.get('monitorableInfoType'),
						monitorableInfoId: self.model.get('monitorableInfoId'),
						masterDataNotificationsId: self.model.get('masterDataNotificationsId')
					}, {
						patch: true,
						success: function () {
						    self.trigger('saveEvent', self.model);
							self.close();
						},
						error: function (model, response) {
						    self.validateResponse(response);
						}
					});
				}
			}			
		},

		bindings: function () {

		    var result = {

		        '#monitorableInfoType': {
		            observe: 'monitorableInfoType',
		            selectOptions: {
		                labelPath: 'name',
		                valuePath: 'id',
		                collection: this.options.checkModuleType,
		                defaultOption: {
		                    label: 'Bitte auswählen',
		                    value: null
		                }
		            },
		        },
		        '#masterDataNotificationsId': {
		            observe: 'masterDataNotificationsId',
		            selectOptions: {
		                labelPath: 'name',
		                valuePath: 'id',
		                collection: this.options.masterDataNotifications,
		                defaultOption: {
		                    label: 'Bitte auswählen',
		                    value: null
		                }
		            },
		        },
		        '#monitorableInfoId': {
		            observe: 'monitorableInfoId',
		            selectOptions: {
		                labelPath: 'name',
		                valuePath: 'id',
		                collection: function () {
		                    var collection,
		                    monitorableInfoType = this.model.get('monitorableInfoType');

		                    if (monitorableInfoType == 1)
		                        collection = this.options.masterDataWcfInfo;
                            else if(monitorableInfoType == 2)
		                        collection = this.options.masterDataSiteInfo;
                            else if (monitorableInfoType == 3)
                                collection = this.options.masterDataJobInfo;
                            else
                                collection = this.options.masterDataWindowsServiceInfo;

		                    return collection.map(function (item) {
		                            return item.toJSON();
		                    });
		                },
		                defaultOption: {
		                    label: 'Bitte auswählen',
		                    value: null
		                }
		            },
		        }
		    };

		    return result;
		},

		render: function () {
			view.__super__.render.apply(this, arguments);

			this.stickit();

			var self = this;

			self.$el.find('#monitorableInfoTypeTitle').text(Resources.monitorableInfoTypeTitle);
			self.$el.find('#monitorableInfoIdTitle').text(Resources.monitorableInfoIdTitle);
			self.$el.find('#masterDataNotificationsIdTitle').text(Resources.masterDataNotificationsIdTitle);
			
			self.$el.find('#select').text(Resources.select);
			self.$el.find('#cancel').text(Resources.cancel);

			self.listenTo(self.model, 'change:monitorableInfoType', function () {

			    self.model.unset('monitorableInfoId', { silent: true });
			    self.model.set('monitorableInfoId', 0);
			});

			return this;
		}
	});

	view.mixin(KendoValidatorFormMixin); 
	view.mixin(KendoWidgetFormMixin);
	view.mixin(LocalizedViewMixin);
	view.mixin(BoundForm);

	return view;
});