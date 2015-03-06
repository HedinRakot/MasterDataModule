define(function () {
	'use strict';

	var getExamClassEditView = function () {
		var d = new $.Deferred();

		require([
            'l!t!DriverLicenceMasterData/ExamClasses/AddExamClass',
            'models/DriverLicenceMasterData/ExamClasses/ExamClass',
			'models/view-collection'
		], function (View, Model, ViewCollection) {
			var model = new Model(),
	            options = _.extend({}, {
	            	model: model
	            });

			ViewCollection.load({
			    examClasses: true,
			    legalBasises: true,
			    coreDataProducts: true
			}).done(function (viewCollection) {
				options = _.extend(options, viewCollection.toJSON());

				d.resolve(new View(options));
			});
		});

		return d.promise();
	},

    getLegalBasisEditView = function () {
        var d = new $.Deferred();

        require([
            'l!t!DriverLicenceMasterData/LegalBasises/AddLegalBasis',
            'models/DriverLicenceMasterData/LegalBasises/LegalBasis',
			'models/view-collection'
        ], function (View, Model, ViewCollection) {
            var model = new Model(),
	            options = _.extend({}, {
	                model: model
	            });


            ViewCollection.load({
                assignationTypes: true,
                legalBasises: true
            }).done(function (viewCollection) {
                options = _.extend(options, viewCollection.toJSON());

                d.resolve(new View(options));
            });
        });

        return d.promise();
        },

        getReturnReasonEditView = function () {
        var d = new $.Deferred();

        require([
            'l!t!DriverLicenceMasterData/ReturnReasons/AddReturnReason',
            'models/DriverLicenceMasterData/ReturnReasons/ReturnReason',
			'models/view-collection'
            ], function (View, Model, ViewCollection) {
            var model = new Model(),
                options = _.extend({ }, {
                    model : model
	            });


            ViewCollection.load().done(function (viewCollection) {
                options = _.extend(options, viewCollection.toJSON());

                d.resolve(new View(options));
            });
            });

        return d.promise();
        },

    getExamRecognitionTypeEditView = function () {
        var d = new $.Deferred();

        require([
            'l!t!DriverLicenceMasterData/ExamRecognitionTypes/AddExamRecognitionType',
            'models/DriverLicenceMasterData/ExamRecognitionTypes/ExamRecognitionType',
			'models/view-collection'
        ], function (View, Model, ViewCollection) {
            var model = new Model(),
	            options = _.extend({}, {
	                model: model
	            });


            ViewCollection.load({
                assignationTypes: true,
                legalBasises: true
            }).done(function (viewCollection) {
                options = _.extend(options, viewCollection.toJSON());

                d.resolve(new View(options));
            });
        });

        return d.promise();
    },

    getCoreDataProductEditView = function () {
        var d = new $.Deferred();

        require([
            'l!t!DriverLicenceMasterData/CoreDataProducts/AddCoreDataProduct',
            'models/DriverLicenceMasterData/CoreDataProducts/CoreDataProduct',
			'models/view-collection'
        ], function (View, Model, ViewCollection) {
            var model = new Model(),
	            options = _.extend({}, {
	                model: model
	            });

            ViewCollection.load({
                sysLanguages: true,
                legalBasises: true,
                examClasses: true,
            }).done(function (viewCollection) {
                options = _.extend(options, viewCollection.toJSON());

                d.resolve(new View(options));
            });
        });

        return d.promise();
    },
    
	factory = {
	    getExamClassCreateView: function () {
	        return getExamClassEditView();
	    },
	    getExamClassEditView: function (id) {
			var d = new $.Deferred();
			getExamClassEditView().done(function (view) {

				view.model.set({ 'id': id });
				view.model.fetch().done(function () {
					d.resolve(view);
				});
			});

			return d.promise();
	    },
	    getLegalBasisCreateView: function () {
	        return getLegalBasisEditView();
	    },
	    getLegalBasisEditView: function (id) {
	        var d = new $.Deferred();
	        getLegalBasisEditView().done(function (view) {

	            view.model.set({ 'id': id });
	            view.model.fetch().done(function () {
	                d.resolve(view);
	            });
	        });

	        return d.promise();
	    },

	     getReturnReasonCreateView: function () {
	        return getReturnReasonEditView();
	    },
	    getReturnReasonEditView: function (id) {
	        var d = new $.Deferred();
	        getReturnReasonEditView().done(function (view) {

	            view.model.set({ 'id': id });
	            view.model.fetch().done(function () {
	                d.resolve(view);
	        });
	        });

	        return d.promise();
	    },

	    getExamRecognitionTypeCreateView: function () {
	        return getExamRecognitionTypeEditView();
	    },
	    getExamRecognitionTypeEditView: function (id) {
	        var d = new $.Deferred();
	        getExamRecognitionTypeEditView().done(function (view) {

	            view.model.set({ 'id': id });
	            view.model.fetch().done(function () {
	                d.resolve(view);
	            });
	        });

	        return d.promise();
	    },

	    getCoreDataProductCreateView: function () {
	        return getCoreDataProductEditView();
	    },
	    getCoreDataProductEditView: function (id) {
	        var d = new $.Deferred();
	        getCoreDataProductEditView().done(function (view) {

	            view.model.set({ 'id': id });
                
	            view.model.fetch().done(function () {
	                d.resolve(view);
	            });
	        });

	        return d.promise();
	    },
	};

    return factory;
});