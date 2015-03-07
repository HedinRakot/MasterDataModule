define([
    'view-factories/CommonMasterDataViewFactory',
    'view-factories/DriverLicenceMasterDataViewFactory'
], function (CommonMasterDataViewFactory, DriverLicenceMasterDataViewFactory) {
	'use strict';

    var getDefaultViewConstructor = function (viewPath, collectionTypes) {
        return function () {
            var d = $.Deferred();
            require([viewPath], function (View) {
            	if (collectionTypes) {
            		require(['models/view-collection'], function (ViewCollection) {
            			ViewCollection.load(collectionTypes).done(function (viewCollection) {
            				d.resolve(new View(viewCollection.toJSON()));
            			});
            		});
            	}
				else
					d.resolve(new View());
            });

            return d.promise();
        };
    },
	showView = function (viewPath, viewConstructor) {
	    var masterView = this.masterView;

	    if (!_.isFunction(viewConstructor))
	    	viewConstructor = getDefaultViewConstructor(viewPath, viewConstructor);

	    var index = viewPath.lastIndexOf('!') + 1;
	    masterView.select(viewPath.substring(index).split('/')[0]);

	    if (Application.user.get('isAuthenticated')) {
	        viewConstructor().done(function (view) {
	            masterView.showView(view, '.content');
	        });
	    }
	    else {
	        require(['t!l!home/login'], function (View) {
	            masterView.showView(new View(), '.content');
	        });
	    }
	},
	view = Backbone.Router.extend({
		initialize: function (options) {
			var self = this;
			this.masterView = options.masterView;
			this.listenTo(Backbone, 'logged-in', function () {
				location.reload();
			});
			this.listenTo(Backbone, 'logged-out', function () {
				location.reload();
			});
			this.listenTo(Backbone, 'forbidden', function () {
				showView.call(self, 'l!t!errors/forbidden');
			});
		},

		routes: {
			'home' : _.partial(showView, 'l!t!home/home'),

			'settings': _.partial(showView, 'l!t!settings/settings'),
			'permissions': _.partial(showView, 'l!t!settings/permissions'),
			'sysTables': _.partial(showView, 'l!t!settings/sysTables', { editModeTypes: true }),
			'roles': _.partial(showView, 'l!t!settings/roles', { permissions: true }),
			'users': _.partial(showView, 'l!t!settings/users', { roles: true}),
			'systemLog': _.partial(showView, 't!settings/systemLog'),
            

			'CommonMasterData': _.partial(showView, 'l!t!CommonMasterData/CommonMasterData'),
			'DriverLicenceMasterData': _.partial(showView, 'l!t!DriverLicenceMasterData/DriverLicenceMasterData'),

			'ExamClasses': _.partial(showView, 'l!t!DriverLicenceMasterData/ExamClasses/ExamClasses', { 
			    examClasses: true,
			    legalBasises: true,
			    coreDataProducts: true }),
			'ExamClasses/create': _.partial(showView, 'l!t!DriverLicenceMasterData/ExamClasses/AddExamClass', DriverLicenceMasterDataViewFactory.getExamClassCreateView),
			'ExamClasses/:id': function (id) {
			    showView.call(this, 'l!t!DriverLicenceMasterData/ExamClasses/AddExamClass', _.partial(DriverLicenceMasterDataViewFactory.getExamClassEditView, id));
			},

			'LegalBasises': _.partial(showView, 'l!t!DriverLicenceMasterData/LegalBasises/LegalBasises', { examClasses: true }),
			'LegalBasises/create': _.partial(showView, 'l!t!DriverLicenceMasterData/LegalBasises/AddLegalBasis', DriverLicenceMasterDataViewFactory.getLegalBasisCreateView),
			'LegalBasises/:id': function (id) {
			    showView.call(this, 'l!t!DriverLicenceMasterData/LegalBasises/AddLegalBasis', _.partial(DriverLicenceMasterDataViewFactory.getLegalBasisEditView, id));
			},

			'ExamRecognitionTypes': _.partial(showView, 'l!t!DriverLicenceMasterData/ExamRecognitionTypes/ExamRecognitionTypes', { examClasses: true }),
			'ExamRecognitionTypes/create': _.partial(showView, 'l!t!DriverLicenceMasterData/ExamRecognitionTypes/AddExamRecognitionType', DriverLicenceMasterDataViewFactory.getExamRecognitionTypeCreateView),
			'ExamRecognitionTypes/:id': function (id) {
			    showView.call(this, 'l!t!DriverLicenceMasterData/ExamRecognitionTypes/AddExamRecognitionType', _.partial(DriverLicenceMasterDataViewFactory.getExamRecognitionTypeEditView, id));
			},

			'ReturnReasons': _.partial(showView, 'l!t!DriverLicenceMasterData/ReturnReasons/ReturnReasons'),
			'ReturnReasons/create': _.partial(showView, 'l!t!DriverLicenceMasterData/ReturnReasons/AddReturnReason', DriverLicenceMasterDataViewFactory.getReturnReasonCreateView),
			'ReturnReasons/:id': function (id) {
			    showView.call(this, 'l!t!DriverLicenceMasterData/ReturnReason/AddReturnReason', _.partial(DriverLicenceMasterDataViewFactory.getReturnReasonEditView, id));
			},


			'CoreDataProducts': _.partial(showView, 'l!t!DriverLicenceMasterData/CoreDataProducts/CoreDataProducts', {
			    sysLanguages: true,
			    legalBasises: true,
			    examClasses: true,
			}),
			'CoreDataProducts/create': _.partial(showView, 'l!t!DriverLicenceMasterData/CoreDataProducts/AddCoreDataProduct', DriverLicenceMasterDataViewFactory.getCoreDataProductCreateView),
			'CoreDataProducts/:id': function (id) {
			    showView.call(this, 'l!t!DriverLicenceMasterData/CoreDataProducts/AddCoreDataProduct', _.partial(DriverLicenceMasterDataViewFactory.getCoreDataProductEditView, id));
			},

			'InsCoreDataProducts': _.partial(showView, 'l!t!CommonMasterData/Product/InsCoreDataProducts/InsCoreDataProducts', {
			    sysLanguages: true,
			}),
			'InsCoreDataProducts/create': _.partial(showView, 'l!t!CommonMasterData/Product/InsCoreDataProducts/AddInsCoreDataProduct', CommonMasterDataViewFactory.getInsCoreDataProductCreateView),
			'InsCoreDataProducts/:id': function (id) {
			    showView.call(this, 'l!t!CommonMasterData/Product/InsCoreDataProducts/AddInsCoreDataProduct', _.partial(CommonMasterDataViewFactory.getInsCoreDataProductEditView, id));
			},

			'EmpEmployees': _.partial(showView, 'l!t!CommonMasterData/Employee/EmpEmployees/EmpEmployees'),
			'EmpEmployees/create': _.partial(showView, 'l!t!CommonMasterData/Employee/EmpEmployees/AddEmpEmployee', CommonMasterDataViewFactory.getEmpEmployeeCreateView),
			'EmpEmployees/:id': function (id) {
			    showView.call(this, 'l!t!CommonMasterData/Employee/EmpEmployees/AddEmpEmployee', _.partial(CommonMasterDataViewFactory.getEmpEmployeeEditView, id));
			},

			'OrgOrganizationalUnits': _.partial(showView, 'l!t!CommonMasterData/Org/OrganizationalUnits/OrganizationalUnits'),
			'OrgOrganizationalUnits/create': _.partial(showView, 'l!t!CommonMasterData/Org/OrgOrganizationalUnits/AddOrgOrganizationalUnit', CommonMasterDataViewFactory.getOrgUnitCreateView),
			'OrgOrganizationalUnits/:id': function (id) {
			    showView.call(this, 'l!t!CommonMasterData/Org/OrgOrganizationalUnits/AddOrganizationalUnit', _.partial(CommonMasterDataViewFactory.getOrgUnitEditView, id));
			}
		}		
	});

	return view;
});