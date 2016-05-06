angular.module('app').factory('AccountResource', function (apiUrl, $resource) {

    return $resource(apiUrl + '/properties/:propertyId', { propertyId: '@PropertyId' }, {

        'update': {
            method: 'PUT'
        }
    });
});