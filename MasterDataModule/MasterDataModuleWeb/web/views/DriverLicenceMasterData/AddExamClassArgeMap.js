define([
	'base/base-object-add-view',
    
], function (BaseView ) {
    'use strict';

    var view = BaseView.extend({

        
        tableName: 'ExamClassArgeMap',
        actionUrl: '#ExamClassArgeMaps',

		bindings: function () {

            var self = this;
            var result = {
			'#examNameArge': 'examNameArge',
			'#examClassId': 'examClassId',
			};

            return result;
		},

        render: function () {

            view.__super__.render.apply(this, arguments);

			//TODO foreach model field
			this.disableInput(this, 'examNameArge');
			this.disableInput(this, 'examClassId', 'numeric');

            return this;
        }
    });

    return view;
});
