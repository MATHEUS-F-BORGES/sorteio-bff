using Microsoft.AspNetCore.Mvc;
using sorteio_bff.Models;


[ApiController]
[Route("api/[controller]")]
public class SorteioController : ControllerBase
{
    [HttpGet]
    public IActionResult GetSorteiosBFF()
    {
        return Ok(TelaSorteio.GenerateFake());
    }
}
