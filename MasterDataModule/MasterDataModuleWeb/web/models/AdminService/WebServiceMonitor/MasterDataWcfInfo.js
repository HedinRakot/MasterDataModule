define(function () {
    'use strict';

    var model = Backbone.Model.extend({
        urlRoot: 'api/MasterDataWcfInfos',
        fields: {
            id: { type: "number", editable: false }
			, name: {
                type: "string",
                editable: true,
                validation: { required: true }
			}

           , wsdlPath: {
                type: "string",
                editable: true,
                validation: { required: true }
           }

            , timeoutChecking: {
               type: "int",
               editable: true,
               validation: { required: true }
            }
        },
        defaults: {timeoutChecking: 10}
    });
    return model;
});