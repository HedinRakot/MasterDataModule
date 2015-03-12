define([
    'base-router'
], function (BaseRouter) {
	'use strict';
    
	var factory = {
	    
	    getAllMasterDataRoutes: function(baseRouter)
	    {
	        var routes = {
				'MessageLocalizations': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/MessageLocalizations'),
	            'MessageLocalizations/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddMessageLocalization', 'models/DriverLicenceMasterData/MessageLocalization', false),
	            'MessageLocalizations/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddMessageLocalization', 'models/DriverLicenceMasterData/MessageLocalization', false),
				'ReturnReasons': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ReturnReasons'),
	            'ReturnReasons/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddReturnReason', 'models/DriverLicenceMasterData/ReturnReason', false),
	            'ReturnReasons/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddReturnReason', 'models/DriverLicenceMasterData/ReturnReason', false),
				'ExamPossibleResults': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ExamPossibleResults'),
	            'ExamPossibleResults/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamPossibleResult', 'models/DriverLicenceMasterData/ExamPossibleResult', false),
	            'ExamPossibleResults/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamPossibleResult', 'models/DriverLicenceMasterData/ExamPossibleResult', false),
				'SchoolInfos': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/SchoolInfos'),
	            'SchoolInfos/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddSchoolInfo', 'models/DriverLicenceMasterData/SchoolInfo', false),
	            'SchoolInfos/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddSchoolInfo', 'models/DriverLicenceMasterData/SchoolInfo', false),
				'ArgeVersions': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ArgeVersions'),
	            'ArgeVersions/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddArgeVersion', 'models/DriverLicenceMasterData/ArgeVersion', false),
	            'ArgeVersions/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddArgeVersion', 'models/DriverLicenceMasterData/ArgeVersion', false),
				'Authorities': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/Authorities'),
	            'Authorities/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddAuthority', 'models/DriverLicenceMasterData/Authority', false),
	            'Authorities/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddAuthority', 'models/DriverLicenceMasterData/Authority', false),
				'Communities': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/Communities'),
	            'Communities/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddCommunity', 'models/DriverLicenceMasterData/Community', false),
	            'Communities/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddCommunity', 'models/DriverLicenceMasterData/Community', false),
				'ExamRecognitionTypes': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ExamRecognitionTypes'),
	            'ExamRecognitionTypes/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamRecognitionType', 'models/DriverLicenceMasterData/ExamRecognitionType', false),
	            'ExamRecognitionTypes/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamRecognitionType', 'models/DriverLicenceMasterData/ExamRecognitionType', false),
				'ExamRooms': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ExamRooms'),
	            'ExamRooms/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamRoom', 'models/DriverLicenceMasterData/ExamRoom', false),
	            'ExamRooms/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamRoom', 'models/DriverLicenceMasterData/ExamRoom', false),
				'ExamStations': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ExamStations'),
	            'ExamStations/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamStation', 'models/DriverLicenceMasterData/ExamStation', false),
	            'ExamStations/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamStation', 'models/DriverLicenceMasterData/ExamStation', false),
				'Holidays': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/Holidays'),
	            'Holidays/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddHoliday', 'models/DriverLicenceMasterData/Holiday', false),
	            'Holidays/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddHoliday', 'models/DriverLicenceMasterData/Holiday', false),
				'ExamClasses': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ExamClasses'),
	            'ExamClasses/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamClass', 'models/DriverLicenceMasterData/ExamClass', false),
	            'ExamClasses/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamClass', 'models/DriverLicenceMasterData/ExamClass', false),
				'Languages': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/Languages'),
	            'Languages/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddLanguage', 'models/DriverLicenceMasterData/Language', false),
	            'Languages/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddLanguage', 'models/DriverLicenceMasterData/Language', false),
				'ExamClassArgeMaps': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ExamClassArgeMaps'),
	            'ExamClassArgeMaps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamClassArgeMap', 'models/DriverLicenceMasterData/ExamClassArgeMap', false),
	            'ExamClassArgeMaps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamClassArgeMap', 'models/DriverLicenceMasterData/ExamClassArgeMap', false),
				'LegalBases': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/LegalBases'),
	            'LegalBases/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddLegalBasis', 'models/DriverLicenceMasterData/LegalBasis', false),
	            'LegalBases/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddLegalBasis', 'models/DriverLicenceMasterData/LegalBasis', false),
				'ExamClassMaps': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ExamClassMaps'),
	            'ExamClassMaps/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamClassMap', 'models/DriverLicenceMasterData/ExamClassMap', false),
	            'ExamClassMaps/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamClassMap', 'models/DriverLicenceMasterData/ExamClassMap', false),
				'ExamConstraints': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/ExamConstraints'),
	            'ExamConstraints/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamConstraint', 'models/DriverLicenceMasterData/ExamConstraint', false),
	            'ExamConstraints/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddExamConstraint', 'models/DriverLicenceMasterData/ExamConstraint', false),
				'MeetingPoints': _.partial(BaseRouter.showView, baseRouter, 'l!t!DriverLicenceMasterData/MeetingPoints'),
	            'MeetingPoints/create': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddMeetingPoint', 'models/DriverLicenceMasterData/MeetingPoint', false),
	            'MeetingPoints/:id': _.partial(BaseRouter.showViewWithModel, baseRouter, 'l!t!DriverLicenceMasterData/AddMeetingPoint', 'models/DriverLicenceMasterData/MeetingPoint', false),
			}
        
	        return routes;
	    }
	};

	return factory;
});
