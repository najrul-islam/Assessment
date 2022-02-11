using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Assessment.Core.Entities;
using Assessment.Core.Repositories;
using Assessment.Infrastructure.Data;
using Assessment.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Infrastructure.Repositories
{
    public class BuildingRepository : Repository<Building>, IBuildingRepository
    {
        public BuildingRepository(AssessmentDbContext assessmentDbContext) : base(assessmentDbContext)
        {
        }

        public async Task<IEnumerable<Building>> GetBuildings()
        {
            return await _assessmentDbContext.Building
                .Where(m => m.Id > 0)
                .ToListAsync();
        }
    }
}
