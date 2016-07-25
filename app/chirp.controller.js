// (function() {
//     'use strict';
//     angular
//         .module('app')
//         .controller('ChirpController', ChirpController);
//     ChirpController.$inject = ['ChirpFactory'];
//     /* @ngInject */
//     function ChirpController(ChirpFactory) {
//         var vm = this;
//         vm.title = 'ChirpController';
//         activate();

//         ////////////////

//         function activate() {
//             ChirpFactory.getChirp()
//             .then(function(response) {
                
//                 vm.chirps = response;

//             })
//         }
//     }
// })();