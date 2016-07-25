(function() {
    'use strict';

    var chirperApp = angular.module('app', ['LocalStorageModule', 'ui.router']);

		chirperApp.config(function($stateProvider, $urlRouterProvider) {

			$urlRouterProvider.otherwise('/state1');

			$stateProvider
			 //calls state1.html which consists the text entry and first movie result
			.state('state1', {  
			    url: '/state1',
			    templateUrl: 'app/partials/state1.html',
			    controller: "AuthController",
			    controllerAs: "vm"
			})

			// second state which consists of details selected movie
			 .state('state2', {  
               	url: "/state2",
               	templateUrl: "app/partials/state2.html",
               	controller: "AuthController",
               	controllerAs: "vm"

             }); 	// end router
		});  		
})();