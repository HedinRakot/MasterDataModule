define([
	'base/base-object-add-view',
    
], function (BaseView ) {
    'use strict';

    var view = BaseView.extend({

        
        tableName: 'ExamStationExamRecognitionType',
        actionUrl: '#ExamStationExamRecognitionTypes',

		bindings: function () {

            var self = this;
            var result = {
			'#examStationId': 'examStationId',
			'#examRecognitionTypeId': { observe: 'examRecognitionTypeId',
				selectOptions: { labelPath: 'name', valuePath: 'id',
				collection: self.options.examRecognitionType
				,defaultOption: {label: self.resources.pleaseSelect,value: null}},},
			'#fromDate': 'fromDate',
			'#toDate': 'toDate',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examStationId', 'numeric');
			this.disableInput(this, 'examRecognitionTypeId', 'select');
			this.disableInput(this, 'fromDate', 'date');
			this.disableInput(this, 'toDate', 'date');

            return this;
        }
    });

    return view;
});
