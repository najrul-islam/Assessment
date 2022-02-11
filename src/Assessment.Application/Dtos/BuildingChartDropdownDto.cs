using Assessment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Dtos
{
    public class BuildingChartDropdownDto
    {
        public IEnumerable<Building> Buildings { get; set; }
        public IEnumerable<Core.Entities.Object> Objects { get; set; }
        public IEnumerable<DataField> DataFields { get; set; }
    }
}
