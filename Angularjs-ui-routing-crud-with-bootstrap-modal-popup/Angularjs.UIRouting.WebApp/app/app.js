
var app = angular.module('MyApp', [
    'ui.router',
    'ui.bootstrap',
    'ngAnimate',
    //'angularFileUpload'
]);

app.config(['$urlRouterProvider', '$stateProvider', function ($urlRouterProvider, $stateProvider) {

    // default route
    $urlRouterProvider.otherwise('/');

    $stateProvider
        .state('home', {
            url: '/',
            templateUrl: 'app/home/home.html',
            controller: 'homeCtrl'
        })
        .state('about', {
            url: '/about',
            templateUrl: 'app/about/about.html',
            controller: 'aboutCtrl'
        })
        .state('contact', {
            url: '/contact',
            templateUrl: 'app/contact/contact.html',
            controller: 'contactCtrl'
        })
        .state('customer', {
            url: '/customer',
            templateUrl: 'app/customer/customer.html',
            controller: 'customerCtrl'
        })
        .state('customer.detail', {
            url: '^/customer/detail/{customerId:[0-9]{1,5}}',
            templateUrl: 'app/customer/customerdetail.html',
            controller: 'customerCtrl'
        })
        .state('customer.detail.contact', {
            url: '^/customer/detail/contact/{customerId:[0-9]{1,5}}',
            templateUrl: 'app/customer/contact.html',
            controller: 'customerContactCtrl'
        })
}]);

app.directive('loading', ['$http', function ($http) {
    return {
        restrict: 'A',
        link: function (scope, elm, attrs) {
            scope.isLoading = function () {
                return $http.pendingRequests.length > 0;
            };
            scope.$watch(scope.isLoading, function (v) {
                if (v) {
                    elm.show();
                } else {
                    elm.hide();
                }
            });
        }
    };

}]);

app.directive('fileUpload', function () {
    return {
        scope: true,        //create a new scope
        link: function (scope, el, attrs) {
            el.bind('change', function (event) {
                var files = event.target.files;
                //iterate files since 'multiple' may be specified on the element
                for (var i = 0; i < files.length; i++) {
                    //emit event upward
                    scope.$emit("fileSelected", { file: files[i] });
                }
            });
        }
    };
});

