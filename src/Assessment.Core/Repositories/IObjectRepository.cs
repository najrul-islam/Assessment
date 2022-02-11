using Assessment.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Repositories
{
    public interface IObjectRepository : IRepository<Entities.Object>
    {
        Task<IEnumerable<Entities.Object>> GetObjects();
    }
}
