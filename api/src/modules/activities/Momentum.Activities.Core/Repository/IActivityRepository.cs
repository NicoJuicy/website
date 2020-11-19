using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace momentum.activities.core.Repository
{
    public interface IActivityRepository
    {
        public Task<List<Models.Activity>> Get();
    }
}
