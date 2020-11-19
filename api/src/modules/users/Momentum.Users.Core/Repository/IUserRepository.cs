using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momentum.Users.Core.Repository
{
    public interface IUserRepository
    {
        Task<IReadOnlyList<Models.User>> Get();
        Task<Models.User> Get(Guid id);

    }
}
