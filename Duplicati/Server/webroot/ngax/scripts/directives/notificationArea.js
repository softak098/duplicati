backupApp.directive('notificationArea', function() {
  return {
    restrict: 'E',
    templateUrl: 'templates/notificationarea.html',
    controller: function($scope, $location, $timeout, NotificationService, ServerStatus, AppService, AppUtils, DialogService) {
    	$scope.Notifications = NotificationService.watch($scope);
        $scope.state = ServerStatus.watch($scope);

        $scope.doDismiss = function(id) {
            AppService.delete('/notification/' + id);
        };

        $scope.doShowLog = function(backupid) {
            AppService.get('/backup/' + backupid + '/isactive').then(
                function() {
                    $location.path('/log/' + backupid);
                },

                function(resp) {

                    if (resp.status == 404) {
                        if ((parseInt(backupid) + '') != backupid)
                            DialogService.dialog('Error', 'The backup was temporary and does not exist anymore, so the log data is lost');
                        else
                            DialogService.dialog('Error', 'The backup is missing, has it been delete?');
                    } else {
                        AppUtils.connectionError('Failed to find backup: ', resp);
                    }

                }
            );
        };

        $scope.doInstallUpdate = function(id) {
            AppService.post('/updates/install');
        };

        $scope.doActivateUpdate = function(id) {
            AppService.post('/updates/activate').then(function() { $scope.doDismiss(id); }, AppUtils.connectionError('Activate failed: '));
        };

        $scope.doShowUpdate = function(id) {
            $location.path('/updatechangelog'); 
        };

        $scope.doDownloadBugreport = function(item) {
            var id = item.Action.substr('bug-report:created:'.length);
            item.DownloadLink = $scope.DownloadLink = AppService.get_bugreport_url(id);
        };
    }
  }
});