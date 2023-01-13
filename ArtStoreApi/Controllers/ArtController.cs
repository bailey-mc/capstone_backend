using ArtStoreApi.Models;
using ArtStoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArtStoreApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArtController : ControllerBase{
    private readonly ArtService _artService;

    public ArtController(ArtService artService) =>
        _artService = artService;
    
    [HttpGet]
    public async Task<List<Art>> Get() =>
        await _artService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Art>> Get(string id)
    {
        var art = await _artService.GetAsync(id);

        if (art is null)
        {
            return NotFound();
        }

        return art;
    }    

    [HttpPost]
    public async Task<IActionResult> Post(Art newArt)
    {
        await _artService.CreateAsync(newArt);

        return CreatedAtAction(nameof(Get), new { id = newArt.Id}, newArt);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Art updatedArt)
    {
        var art = await _artService.GetAsync(id);
        
        if (art is null)
        {
            return NotFound();
        }

        updatedArt.Id = art.Id;

        await _artService.UpdateAsync(id, updatedArt);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var art = await _artService.GetAsync(id);

        if (art is null)
        {
            return NotFound();
        }

        await _artService.RemoveAsync(id);

        return NoContent();
    }
}