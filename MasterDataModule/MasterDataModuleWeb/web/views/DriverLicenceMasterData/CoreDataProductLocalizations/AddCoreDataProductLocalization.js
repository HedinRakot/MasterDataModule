define([
	'base/base-add-model-view'
], function (BaseView) {
	'use strict';

	var view = BaseView.extend({
	    bindings: function () {

			var result = {
			    '#name': 'name',
			    '#description': 'description',
			    '#fromDate': 'fromDate',
			    '#toDate': 'toDate',
				'#sysLanguageId': {
				    observe: 'sysLanguageId',
				    selectOptions: {
				        labelPath: 'name',
				        valuePath: 'id',
				        collection: this.options.sysLanguages,
				        defaultOption: {
				            label: 'Sprache auswählen',
				            value: null
				        }
				    },
				},
			}

			return result;
		},

		initialize: function () {
			view.__super__.initialize.apply(this, arguments);

			this.model = new this.collection.model(); //TODO
			this.model.set('coreDataProductId', this.options.model.id);
		}
	});


	return view;
});