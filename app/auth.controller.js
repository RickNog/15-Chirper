(function() {
    'use strict';
    angular
        .module('app')
        .controller('AuthController', AuthController);

    AuthController.$inject = ['AuthFactory'];
    
    /* @ngInject */
    function AuthController(AuthFactory) {
        var vm = this;
        vm.title = 'AuthController';
        vm.login = login;
        vm.register = register;

        // activate();

        ////////////////

        // function activate() {
        // 	AuthFactory.getLoginInfo()
        //         .then(function(response) {

        //     })
        // }


        // Login data
        function login(username, password) {
            AuthFactory.login(username, password)
            .then (function(response) {

            	vm.holdData = response;

            }

           )};

        

    }

    // Login data
        function register(email, password, confirmpassword) {
            AuthFactory.register(email, password, confirmpassword)
            .then (function(response) {

                vm.regData = response;

            }

           )};

    debugger;
})();