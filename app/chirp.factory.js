(function() {
    'use strict';
    angular
        .module('app')
        .factory('ChirpFactory', ChirpFactory);
    ChirpFactory.$inject = ['$http'];
    
    /* @ngInject */
    function ChirpFactory($http) {
        var service = {
            getChirp: getChirp
        };
        return service;

        ////////////////

        function getChirp() {
            return $http({
                method: 'POST',
                url: ''
            }).then(function(response) {

                return response.data;

            });
        }
    }
})();