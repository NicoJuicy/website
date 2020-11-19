using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using momentum.framework.core.Models;
using momentum.framework.core.Services;

namespace Momentum.Api.Services
{

    public class UserService : IUserService
    {
        private HttpContext m_httpcontext;
        public UserService(HttpContext httpcontext)
        {
            m_httpcontext = httpcontext;
        }
        private User currentUser;

        public async Task<User> GetCurrentUser()
        {
            if (currentUser != null)
                return currentUser;


            var userId = m_httpcontext.Request.Headers["UserId"];

            //get user from headers
            return new User()
            {
                UserId = Guid.Parse(userId)
            };
        }
    }
}
