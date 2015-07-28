var app = angular.module('dialogs.controllers', ['ui.bootstrap.modal']);

app.controller('errorDialogCtrl', ['$scope', '$modalInstance', 'msg', function ($scope, $modalInstance, msg) {

    $scope.msg = (angular.isDefined(msg)) ? msg : 'An unexpected error has occurred.';

    $scope.close = function () {
        $modalInstance.close();
    }; 
}]);

/*    Progress Controller
************************************/
app.controller('progressDialogCtrl', ['$scope', '$modalInstance', '$timeout', 'msg', 'progress', function ($scope, $modalInstance, $timeout, msg, progress) {
    //-- Variables -----//

    $scope.msg = (angular.isDefined(msg)) ? msg : 'Waiting on operation to complete.';
    $scope.progress = (angular.isDefined(progress)) ? progress : 100;

    //-- Listeners -----//

    // Note: used $timeout instead of $scope.$apply() because I was getting a $$nextSibling error

    // close wait dialog
    $scope.$on('dialogs.wait.complete', function () {
        $timeout(function () {
            $modalInstance.close();
        });
    }); // end on(dialogs.wait.complete)

    // update the dialog's message

    $scope.$on('dialogs.wait.message', function (evt, args) {
        $scope.msg = (angular.isDefined(args.msg)) ? args.msg : $scope.msg;
    }); // end on(dialogs.wait.message)

    // update the dialog's progress (bar) and/or message
    $scope.$on('dialogs.wait.progress', function (evt, args) {
        $scope.msg = (angular.isDefined(args.msg)) ? args.msg : $scope.msg;
        $scope.progress = (angular.isDefined(args.progress)) ? args.progress : $scope.progress;
    }); // end on(dialogs.wait.progress)

    //-- Methods -----//
    $scope.getProgress = function () {
        return {
            'width': $scope.progress + '%'
        };
    }; // end getProgress
}]); // end WaitDialogCtrl

/*   Notify Dialog Controller 
 ************************************/
app.controller('notifyDialogCtrl', ['$scope', '$modalInstance', 'header', 'msg', function ($scope, $modalInstance, header, msg) {
    //-- Variables -----//

    $scope.header = (angular.isDefined(header)) ? header : 'Notification';
    $scope.msg = (angular.isDefined(msg)) ? msg : 'Unknown application notification.';

    //-- Methods -----//

    $scope.close = function () {
        $modalInstance.close();
    }; // end close
}]); // end WaitDialogCtrl

/*    Confirm Dialog Controller 
 ************************************/
app.controller('confirmDialogCtrl', ['$scope', '$modalInstance', 'header', 'msg', function ($scope, $modalInstance, header, msg) {
    //-- Variables -----//
 
    $scope.header = (angular.isDefined(header)) ? header : 'Confirmation';
    $scope.msg = (angular.isDefined(msg)) ? msg : 'Confirmation required.';
 
    //-- Methods -----//
 
    $scope.no = function () {
        $modalInstance.dismiss('no');
    }; // end close
 
    $scope.yes = function () {
        $modalInstance.close('yes');
    }; // end yes
}]); // end ConfirmDialogCtrl / dialogs.controllers

