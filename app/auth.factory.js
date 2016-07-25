(function() {
    'use strict';
    angular
        .module('app')
        .factory('AuthFactory', AuthFactory);
    AuthFactory.$inject = ['$http', '$q', '$location', 'localStorageService'];
    /* @ngInject */
    function AuthFactory($http, $q, $location, localStorageService) {
        var state = {
        	loggedIn: false
        };
        var service = {
            login : login,
            register : register
            
        };
        return service;

        ////////////////



        //Submits login info

        function login(username, password) {
        	logout();
                var data = "grant_type=password&username=" + username + "&password=" + password;
             return $http({
                method: 'POST',
                url: 'http://localhost:57615/api/token',
                data: data,
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
                
            }).then(function(response) {
            	// stash the JWT and username in local storage
            	localStorageService.set('authorizationData', response.data);
            	localStorageService.set('username', username);
            
            return response.data;

            });

            debugger;


        }

        function logout() {
           localStorageService.remove('authorizationData');
           state.loggedIn = false;
           $location.path('#/login');
       }

       //Adds data
        function register(email, password, confirmpassword) {
                var data = { email, password, confirmpassword }
             return $http({
                method: 'POST',
                url: 'http://localhost:57615/api/accounts/register',
                data: data
            }).then(function(response) {


             return response.data;
            

            });

            debugger;


        }
    }
})();