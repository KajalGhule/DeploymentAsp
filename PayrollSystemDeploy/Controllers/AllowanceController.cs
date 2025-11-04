using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using PayrollWebApp.DTO;
using PayrollWebApp.Services.Interface;

namespace PayrollWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AllowanceController : Controller
    {
        private readonly IAllowanceService _svc;
        private readonly ILogger<AllowanceController> _logger;

        public AllowanceController(IAllowanceService service, ILogger<AllowanceController> logger)
        {
            _svc = service;
            _logger = logger;
        }

        [HttpGet("allowances")]
        public async Task<IActionResult> GetAllAllowances()
        {
            _logger.LogInformation("Fetching all allowances at {time}", DateTime.Now);
            List<AllowanceDTO> allowances = await _svc.GetAllAllowances();
            if (allowances == null || allowances.Count == 0)
            {
                _logger.LogWarning("No allowances found at {time}", DateTime.Now);
                return NotFound("No allowances found.");
            }
            _logger.LogInformation("Successfully retrieved {count} allowances", allowances.Count);
            return Ok(allowances);
        }


        [HttpPut("allowances/{id}")]
        public async Task<IActionResult> UpdateAllowance(int id, [FromBody] AllowanceDTO allowanceDto)
        {
            if (allowanceDto == null)
            {
                _logger.LogWarning("UpdateAllowance called with null DTO at {time}", DateTime.UtcNow);
                return BadRequest("Allowance data is required.");
            }

            if (id != allowanceDto.AllowanceID)
            {
                _logger.LogWarning("ID mismatch: route ID {routeId} != DTO ID {dtoId} at {time}",
                                    id, allowanceDto.AllowanceID, DateTime.UtcNow);
                return BadRequest("ID in route does not match ID in payload.");
            }

            try
            {
                _logger.LogInformation("Updating allowance with ID {id} at {time}", id, DateTime.UtcNow);

                var updated = await _svc.UpdateAllowance(allowanceDto);

                if (!updated)
                {
                    _logger.LogWarning("Allowance with ID {id} not found for update at {time}", id, DateTime.UtcNow);
                    return NotFound($"Allowance with ID {id} not found.");
                }

                _logger.LogInformation("Successfully updated allowance with ID {id} at {time}", id, DateTime.UtcNow);
                return NoContent(); // or Ok(allowanceDto) if you want to return updated data
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating allowance with ID {id} at {time}", id, DateTime.UtcNow);
                return StatusCode(500, "An error occurred while updating the allowance.");
            }
        }


        [HttpDelete("allowances/{id}")]
        public async Task<IActionResult> DeleteAllowance(int id)
        {
            try
            {
                bool deleted = await _svc.DeleteAllowance(id);

                if (!deleted)
                    return NotFound($"Allowance with ID {id} not found.");

                return NoContent(); // successfully deleted
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message); 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting allowance {id}", id);
                return StatusCode(500, "An error occurred while deleting allowance.");
            }
        }

        [HttpPost("allowances")]
        public async Task<IActionResult> AddAllowance([FromBody] AllowanceDTO allowanceDto)
        {
            try
            {
                if (allowanceDto == null)
                    return BadRequest("Allowance data is required.");

                int newId = await _svc.AddAllowance(allowanceDto);

                allowanceDto.AllowanceID = newId; // set the newly generated ID

                return StatusCode(201, allowanceDto); //return 201 Created with object
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new allowance at {time}", DateTime.UtcNow);
                return StatusCode(500, "An error occurred while adding the allowance.");
            }
        }

        [HttpGet("allowance/{id}")]
        public async Task<IActionResult> GetAllowanceById(int id)
        {
            _logger.LogInformation("Fetching all allowances at {time}", DateTime.UtcNow);
            AllowanceDTO allowances = await _svc.GetAllowanceById(id);
            if (allowances == null)
            {
                _logger.LogWarning("No allowances found at {time}", DateTime.UtcNow);
                return NotFound("No allowances found.");
            }
            _logger.LogInformation("Successfully retrieved allowance");
            return Ok(allowances);
        }
    }
}
