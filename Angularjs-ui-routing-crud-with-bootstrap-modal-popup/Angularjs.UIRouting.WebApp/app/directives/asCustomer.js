
var app = angular.module('MyApp');

app.directive("asCustomer", function () {
    return {
        restrict: 'E',
        replace: 'true',
        templateUrl: 'app/customer/userListRow.html'
    }
});