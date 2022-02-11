using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Assessment.Core.Entities;
using Assessment.Core.Repositories.Base;

namespace Assessment.Core.Repositories
{
    public interface IBuildingRepository : IRepository<Building>
    {
        Task<IEnumerable<Building>> GetBuildings();
    }
}
