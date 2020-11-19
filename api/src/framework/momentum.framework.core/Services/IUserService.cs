using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace momentum.framework.core.Services
{
    public interface IUserService
    {
        Task<Models.User> GetCurrentUser();
    }
}
