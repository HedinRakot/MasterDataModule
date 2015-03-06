define([
	'base/base-add-model-view'
], function (BaseView) {
	'use strict';

	var view = BaseView.extend({
	    bindings: function () {

			var result = {
			    '#fromDate': 'fromDate',
			    '#toDate': 'toDate',
				'#requiredExamClassId': {
				    observe: 'requiredExamClassId',
				    selectOptions: {
				        labelPath: 'name',
				        valuePath: 'id',
				        collection: this.options.examClasses,
				        defaultOption: {
				            label: 'Fahrerlaubnisklasse auswählen',
				            value: null
				        }
				    },
				},
			}

			return result;
		},

		initialize: function () {
			view.__super__.initialize.apply(this, arguments);

			this.model = new this.collection.model();
			this.model.set('examClassId', this.options.model.id);
		}
	});


	return view;
});