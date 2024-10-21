﻿using Microsoft.AspNetCore.Mvc;

namespace Software.Api.Catalog;

public class CatalogController : ControllerBase
{
    [HttpPost("/Catalog")]
    public record Task<ActionResult> AddSoftwareCatalogAsync(
        [FromBody] CatalogCreateModel request)
    {
        var response = new CatalogResponseModel()
        {
            Id = Guid.Empty,
            IsOpenSource = request.IsOpenSource,
            Title = request.Title,
            Vendor = request.Vendor,
        };

        return Ok(response);
    }
}


public record CatalogCreateModel
{
    public string Title { get; set; } = string.Empty;
    public string Vendor { get; set; } = string.Empty;
    public bool IsOpenSource { get; set; }
}

public record CatalogResponseModel
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Vendor { get; set; } = string.Empty;
    public bool IsOpenSource { get; set; }
}

public class CatalogEntity
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Vendor { get; set; } = string.Empty;
    public bool IsOpenSource { get; set; }
}