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
    public class DataFieldRepository : Repository<DataField>, IDataFieldRepository
    {
        public DataFieldRepository(AssessmentDbContext assessmentDbContext) : base(assessmentDbContext)
        {
        }

        public async Task<IEnumerable<DataField>> GetDataFields()
        {
            return await _assessmentDbContext.DataField
                .Where(m => m.Id > 0)
                .ToListAsync();
        }
    }
}
