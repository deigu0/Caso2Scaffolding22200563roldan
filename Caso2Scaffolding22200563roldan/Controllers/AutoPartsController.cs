using Caso2Scaffolding22200563roldan.Models;
using Caso2Scaffolding22200563roldan.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Caso2Scaffolding22200563roldan.Controllers
{
    public class AutoPartsController
    {
        private readonly IAutoPartsRepository _autoPartsRepository;

        public AutoPartsController(IAutoPartsRepository autoPartsRepository)
        {
            _autoPartsRepository = autoPartsRepository;
        }

        // GET: api/AutoParts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AutoParts>>> GetAllAutoParts()
        {
            var autoParts = await _autoPartsRepository.GetAllAutoPartsAsync();
            return Ok(autoParts);
        }

        // POST: api/AutoParts
        [HttpPost]
        public async Task<ActionResult> AddAutoPart(AutoParts autoPart)
        {
            await _autoPartsRepository.AddAutoPartAsync(autoPart);
            return CreatedAtAction(nameof(GetAllAutoParts), new { id = autoPart.Id }, autoPart);
        }

        // PUT: api/AutoParts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAutoPart(int id, AutoParts autoPart)
        {
            if (id != autoPart.Id)
            {
                return BadRequest();
            }

            await _autoPartsRepository.UpdateAutoPartAsync(autoPart);
            return NoContent();
        }

        // DELETE: api/AutoParts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutoPart(int id)
        {
            await _autoPartsRepository.DeleteAutoPartAsync(id);
            return NoContent();
        }
    }

}
