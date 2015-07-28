
var app = angular.module("MyApp");
app.controller("customerContactCtrl", ['$scope', '$state', '$stateParams', '$modal', '$log', 'Customer', function ($scope, $state, $stateParams, $modal, $log, Customer) {

    var customerId = $stateParams.customerId;

    $scope.customerContacts = function (id) {
        return Customer.customerContacts(id)
        .then(function (data) {
            $scope.contacts = Customer.conntacts;
        });
    };

    $scope.customerContacts(customerId);
}]);