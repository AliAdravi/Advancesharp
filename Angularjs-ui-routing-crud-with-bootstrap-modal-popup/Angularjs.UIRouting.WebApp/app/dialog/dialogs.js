
var app = angular.module('dialogs.services', ['ui.bootstrap.modal', 'dialogs.controllers']);

app.factory('$dialogs', ['$modal', function ($modal) {

    return {
        /* Error message dialog, with message parameter */
        error: function (msg) {
            return $modal.open({
                templateUrl: 'app/dialog/error.html',
                controller: 'errorDialogCtrl',
                resolve: {
                    msg: function () {
                        return angular.copy(msg);
                    }
                }
            }); // end of error modal open
        }, // end error


        /* notify dialog, with title and message parameter */
        notify: function (title, msg) {
            return $modal.open({
                templateUrl: 'app/dialog/notify.heml',
                controller: 'notifyDialogCtrl',
                resolve: {
                    title: function () {
                        return angular.copy(title);
                    },
                    msg: function () {
                        msg: angular.copy(msg);
                    }
                }
            }); // end of notify modal open
        }, // end of notify model

        /* progress dialog, with message and progress parameter */
        progress: function (msg, progress) {
            return $modal.open({
                templateUrl: 'app/dialog/progress.heml',
                controller: 'progressDialogCtrl',
                resolve: {
                    progress: function () {
                        return angular.copy(progress);
                    },
                    msg: function () {
                        msg: angular.copy(msg);
                    }
                }
            }); // end of progress modal open
        }, // end of notify 

        /* confirm dialog, with title and message parameter */
        confirm: function (title, msg) {
            return $modal.open({
                templateUrl: 'app/dialog/confirm.heml',
                controller: 'confirmDialogCtrl',
                resolve: {
                    title: function () {
                        return angular.copy(title);
                    },
                    msg: function () {
                        msg: angular.copy(msg);
                    }
                }
            }); // end of confirm modal open
        }, // end of confirm model

        /* create dialog parameters
            String: templateUrl, 
            String: controllerName, 
            Object: data, 
            Object: options{ keyboard: true/false, backdrop: true/false/static } */
        create: function (templateUrl, controllerName, data, options) {
            var key = (angular.isDefined(options.key)) ? opts.key : true;
            var back = (angular.isDefined(options.back)) ? opts.back : true;
           
            return $modal.open({
                templateUrl: templateUrl,
                controller: controllerName,
                keyboard: key,
                backdrop: back,
                resolve: {
                    data: function () {
                        return angular.copy(data);
                    }
                }
            }); // end of create modal open
        }
    }
}]);