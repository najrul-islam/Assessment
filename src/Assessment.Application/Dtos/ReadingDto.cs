using Assessment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Dtos
{
    public class ReadingDto
    {
        public int BuildingId  { get; set; }
        public int ObjectId { get; set; }
        public int DataFieldId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.UtcNow.AddDays(30);
    }
}
