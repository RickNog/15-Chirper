(function () {
  'use strict';

  angular
      .module('app')
      .factory('AuthInterceptor', AuthInterceptor);

  AuthInterceptor.$inject = ['$q', '$location', 'localStorageService'];

  /* @ngInject */
  function AuthInterceptor($q, $location, localStorageService) {
      var service = {
          request: request,
          response: response,
          requestError: requestError,
          responseError: responseError
      };
      return service;
      

function request(config) {

          config.headers = config.headers || {};
          var authData = localStorageService.get("authorizationData");
          if (authData) {
              config.headers.Authorization = "Bearer " + authData.access_token;
          }
          return config;
      }

      function response(response) {
          return response || $q.when(response);
      }

      function requestError(rejection) {
          return $q.reject(rejection);
      }

      function responseError(rejection) {
          if (rejection.status === 401) {
              localStorageService.remove("authorizationData");
              $location.path('#/login');
          }
          return $q.reject(rejection);
      }
  }
})();

// app.factory('BearerAuthInterceptor', function ($window, $q) {
//     return {
//         request: function(config) {
//             config.headers = config.headers || {};
//             if ($window.localStorage.getItem('token')) {
//               // may also use sessionStorage
//                 config.headers.Authorization = 'Bearer ' + $window.localStorage.getItem('token');
//             }
//             return config || $q.when(config);
//         },
//         response: function(response) {
//             if (response.status === 401) {
//                 //  Redirect user to login page / signup Page.
//             }
//             return response || $q.when(response);
//         }
//     };
// });

// //Register the previously created AuthInterceptor.
// app.config(function ($httpProvider) {
//     $httpProvider.interceptors.push('BearerAuthInterceptor');
// });