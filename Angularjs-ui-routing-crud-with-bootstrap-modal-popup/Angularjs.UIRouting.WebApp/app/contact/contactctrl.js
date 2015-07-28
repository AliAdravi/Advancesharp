
angular.module("MyApp")
       .controller("contactCtrl", ['$scope', function ($scope) {

           var headOffice = {
               'address': '1234 Queens Plaza, Queens, New York',
               'contactNo': '(291) 628-3327',
               'fax': '(291) 628-3328',
               'email': 'headoffice@advancesharp.com',
           };

           var branch1 = {
               'address': '76 Golden Street, Manhattan New York',
               'contactNo': '(291) 628-1127',
               'fax': '(291) 628-1128',
               'email': 'brach1office@advancesharp.com',
           };


           var branch2 = {
               'address': '58-17 Junction Blvd. Long Island, New York',
               'contactNo': '(291) 628-1027',
               'fax': '(291) 628-1028',
               'email': 'brach2office@advancesharp.com',
           };

           $scope.pageTitle = 'Contact Us';
           $scope.headOffice = headOffice;
           $scope.branch1 = branch1;
           $scope.branch2 = branch2;

       }]);