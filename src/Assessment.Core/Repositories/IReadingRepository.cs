using Assessment.Core.Entities;
using Assessment.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Repositories
{
    public interface IReadingRepository : IRepository<Reading>
    {
        Task<IEnumerable<Reading>> GetReadings(int buildingId, int objectId, int dataFieldId, DateTime startDate, DateTime endDate);
    }
}
