using Microsoft.AspNetCore.Mvc;

namespace Software.Api.Catalog;

public class CatalogController : ControllerBase
{
    [HttpPost("/Catalog")]
    public async Task<ActionResult> AddSoftwareCatalogAsync()
    {
        return Ok();
    }
}
