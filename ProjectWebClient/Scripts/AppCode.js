var mainApp = angular.module('mainApp', ['ngRoute']);

mainApp.run(function ($rootScope) {
    $rootScope.api = "http://localhost:4247/"
});

var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider.
        when
}