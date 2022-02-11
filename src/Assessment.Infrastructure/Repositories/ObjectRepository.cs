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
    public class ObjectRepository : Repository<Core.Entities.Object>, IObjectRepository
    {
        public ObjectRepository(AssessmentDbContext assessmentDbContext) : base(assessmentDbContext)
        {
        }

        public async Task<IEnumerable<Core.Entities.Object>> GetObjects()
        {
            return await _assessmentDbContext.Object
                .Where(m => m.Id > 0)
                .ToListAsync();
        }
    }
}
