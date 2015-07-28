angular.module('MyApp')
       .factory('Customer', ['$q', '$http', function ($q, $http) {

           var baseUrl = 'api/customer/';
           var contactBaseUrl = 'api/Contact/';

           var customerService = {};
           customerService.customers = [];
           customerService.currentCustomer = {};

           // Search Customers
           customerService.search = function (text) {
               var deferred = $q.defer();
               return $http({
                   url: baseUrl + 'search',
                   method: 'GET',
                   params: { 'searchText': text },
                   cache: true
               }).success(function (data) {
                   deferred.resolve(
                       customerService.customers = data);
               }).error(function (error) {
                   deferred.reject(error);
               })
               return deferred.promise;
           }

           // New Customers
           customerService.newCustomer = function () {
               var deferred = $q.defer();
               return $http.get(baseUrl + "new")
                    .success(function (data) {
                        deferred.resolve(customerService.customer = data);
                    })
               .error(function (error) {
                   deferred.reject(error);
               })
               return deferred.promise;
           }

           // Save Customer
           customerService.Save = function (customer, files) {
               var deferred = $q.defer();
               //return $http.post(baseUrl + "Save", customer)
               $http({
                   method: 'POST',
                   url: baseUrl + "Save",
                   //IMPORTANT!!! You might think this should be set to 'multipart/form-data' 
                   // but this is not true because when we are sending up files the request 
                   // needs to include a 'boundary' parameter which identifies the boundary 
                   // name between parts in this multi-part request and setting the Content-type 
                   // manually will not set this boundary parameter. For whatever reason, 
                   // setting the Content-type to 'false' will force the request to automatically
                   // populate the headers properly including the boundary parameter.
                   headers: { 'Content-Type': 'application/json' },

                   data: { model: customer, files: files }
               })
                .success(function (data) {
                    deferred.resolve(customerService.customer = data);
                })

               .error(function (error) {
                   deferred.reject(error);
               });
               return deferred.promise;
           }

           // Customers detail by customer id
           customerService.customerDetail = function (id) {
               var deferred = $q.defer();
               return $http.get(baseUrl + "detail/" + id)
                    .success(function (data) {
                        deferred.resolve(
                            customerService.currentCustomer = data);
                    })
               .error(function (error) {
                   deferred.reject(error);
               })
               return deferred.promise;
           }

           // delete Customers
           customerService.delete = function (id) {
               var deferred = $q.defer();
               return $http.post(baseUrl + "delete/" + id)
                    .success(function (data) {
                        deferred.resolve();
                    })
               .error(function (error) {
                   deferred.reject(error);
               })
               return deferred.promise;
           }

           //// delete Customers
           //customerService.contacts = function (id) {
           //    var deferred = $q.defer();
           //    return $http.post(baseUrl + "delete/" + id)
           //         .success(function (data) {
           //             deferred.resolve();
           //         })
           //    .error(function (error) {
           //        deferred.reject(error);
           //    })
           //    return deferred.promise;
           //}

           /*       CUSTOMER CONTACTS
            ************************************/
           customerService.customerContacts = function (id) {
               var deferred = $q.defer();
               return $http.get(contactBaseUrl + "ByCustomerId/" + id)
                    .success(function (data) {
                        deferred.resolve(customerService.conntacts = data);
                    }).error(function (error) {
                        deferred.reject(error);
                    })
               return deferred.promise;
           }

           return customerService;
       }]);