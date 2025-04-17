using Microsoft.AspNetCore.Mvc;
using SoftwareServerpp.Models;
using System.Text;

namespace SoftwareServerpp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SoftwareDetailsAPI : ControllerBase
    {
        [HttpPost]
        public IActionResult GetSoftwareDetails([FromBody] List<SoftwareDetails> data)
        {
            if (data == null)
            {
                return BadRequest("Invalid Data");
            }

            var CsvBuilder = new StringBuilder();
            CsvBuilder.AppendLine("DisplayName,DisplayVersion,Publisher,InstallDate,InstallLocation,EstimatedSize");
            foreach (var software in data)
            {
                CsvBuilder.AppendLine($"{software.DisplayName},{software.DisplayVersion},{software.Publisher},{software.InstallDate},{software.InstallLocation},{software.EstimatedSize}");
            }
            var csvBytes = Encoding.UTF8.GetBytes(CsvBuilder.ToString());
            var fileName = $"SoftwareDetails{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            return File(csvBytes, "text/csv", fileName);
        }
    }
}
