using Assessment.Core.Entities;
using Assessment.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Repositories
{
    public interface IDataFieldRepository : IRepository<DataField>
    {
        Task<IEnumerable<DataField>> GetDataFields();
    }
}
