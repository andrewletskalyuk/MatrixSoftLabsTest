using MatrixSoft.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace MatrixSoft.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HolidayController : ControllerBase
{
    private readonly HolidayService _holidayService;

    public HolidayController(HolidayService holidayService)
    {
        _holidayService = holidayService;
    }

    [HttpGet("swedish-red-days")]
    public async Task<IActionResult> GetSwedishRedDays()
    {
        var holidays = await _holidayService.GetSwedishRedDays();
        return Ok(holidays);
    }
}
