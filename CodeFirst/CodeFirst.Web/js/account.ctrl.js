angular.module('app').controller('AccountController', function ($scope, AccountResource, $stateParams) {

    $scope.Account = {};

    $scope.saveAccount = function () {

        AccountResource.save($scope.Account, function () {
            $scope.Account = {};
                alert('It is OK');
            });
        };
});
