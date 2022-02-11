using Assessment.Application.Dtos;
using Assessment.Core.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Assessment.API.Controllers
{
    public class BuildingController : ApiBaseController
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly IObjectRepository _objectRepository;
        private readonly IDataFieldRepository _dataFieldRepository;
        private readonly IReadingRepository _readingRepository;
        public BuildingController(IBuildingRepository buildingRepository,
            IObjectRepository objectRepository,
            IDataFieldRepository dataFieldRepository, IReadingRepository readingRepository)
        {
            _buildingRepository = buildingRepository;
            _objectRepository = objectRepository;
            _dataFieldRepository = dataFieldRepository;
            _readingRepository = readingRepository;
        }
        // GET: api/<BuildingController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var buildings = await _buildingRepository.GetAllAsync();
            return Ok(buildings);
        }
        // GET: api/Building/GetDropdownList
        [HttpGet("GetDropdownList")]
        public async Task<IActionResult> GetDropdownList()
        {
            var buildings = await _buildingRepository.GetAllAsync();
            var objects = await _objectRepository.GetAllAsync();
            var dataFields = await _dataFieldRepository.GetAllAsync();
            return Ok(new BuildingChartDropdownDto()
            {
                Buildings = buildings,
                Objects = objects,
                DataFields = dataFields
            });
        }

        // GET: api/Building/GetReadings
        [HttpGet("GetReadings/{buildingId}/{objectId}/{dataFieldId}/{startDate}/{endDate}")]
        public async Task<IActionResult> GetReadings(int buildingId, int objectId, int dataFieldId, string startDate, string endDate)
        {
            var readings = await _readingRepository.GetReadings(buildingId, objectId, dataFieldId, DateTime.UtcNow, DateTime.UtcNow);
            readings = readings.OrderBy(x => x.Timestamp);
            return Ok(readings);
        }

        // GET: api/Building/GetReadingsObj
        [HttpPost("GetReadingsObj")]
        public async Task<IActionResult> GetReadingsObj(ReadingDto reading)
        {
            var readings = await _readingRepository.GetReadings(reading.BuildingId, reading.ObjectId, reading.DataFieldId, reading.StartDate, reading.EndDate);
            readings = readings.OrderBy(x => x.Timestamp);
            return Ok(readings);
        }
    }
}
