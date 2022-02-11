using Assessment.Core.Entities;
using Assessment.Core.Repositories;
using Assessment.Infrastructure.Data;
using Assessment.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Infrastructure.Repositories
{
    public class ReadingRepository : Repository<Reading>, IReadingRepository
    {
        public ReadingRepository(AssessmentDbContext assessmentDbContext) : base(assessmentDbContext)
        {
        }

        public async Task<IEnumerable<Reading>> GetReadings(int buildingId, int objectId, int dataFieldId, DateTime startDate, DateTime endDate)
        {   
            return await _assessmentDbContext.Reading
                .Where(m => m.BuildingId == buildingId 
                && m.ObjectId ==  objectId 
                && m.DataFieldId == dataFieldId
                && m.Timestamp >= startDate 
                && m.Timestamp <= endDate
                ).ToListAsync();
        }
    }
}
