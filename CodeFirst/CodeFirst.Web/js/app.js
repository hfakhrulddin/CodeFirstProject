angular.module('app', ['ngResource', 'ui.router']);

angular.module('app').value('apiUrl', 'http://localhost:55029/api');

angular.module('app').config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('account');
   
    $stateProvider

        .state('app.account', { url: '/account', templateUrl: '/templates/account.html', controller: 'AccountGridController' })
    

});

