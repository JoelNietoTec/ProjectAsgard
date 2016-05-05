var ClientsController = function ($scope) {
    $scope.getClients = function ($http) {
        return $http.get("http://localhost:4247/api/Clients");
    }
    $scope.getClients()
        .success(function (result) {
            $scope.clients = result;
        })
}