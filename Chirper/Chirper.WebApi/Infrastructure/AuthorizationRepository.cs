﻿using Chirper.WebApi.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using System;

namespace Chirper.WebApi.Infrastructure
{
    public class AuthorizationRepository : IDisposable
    {
        private UserManager<ChirperUser> _userManager;
        private DataContext _dataContext;

    public AuthorizationRepository()
    {
        _dataContext = new DataContext();
        var userStore = new UserStore<ChirperUser>(_dataContext);
        _userManager = new UserManager<ChirperUser>(userStore);
    }

        // Task for registering new user
        public async Task<IdentityResult> RegisterUser(RegistrationModel userModel)
        {
            // Instantiate new ChirpUser
            ChirperUser user = new ChirperUser
            {
                UserName = userModel.EmailAddress,
                Email = userModel.EmailAddress

            };

            // Creates the user, stores the password in ecrypted format
            var result = await _userManager.CreateAsync(user, userModel.Password);

            return result;

        }

        // Passes registration to user manager to do a search, return null if no result
        public async Task<ChirperUser> FindUser(string username, string password)
        {
            return await _userManager.FindAsync(username, password);
        }


        public void Dispose()
        {
            _dataContext.Dispose();
            _userManager.Dispose();
        }

    }
}