using Microsoft.AspNetCore.Mvc;
using vatusAPI.Services.VatusService;

namespace vatusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VatusController : Controller
    {
        private readonly IVatuService _vatuService;

        public VatusController(IVatuService vatuService)
        {
            _vatuService = vatuService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vatus>>> GetAllVatus()
        {
            
            return _vatuService.GetAllVatus(); 
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Vatus>> GetSingleVatus(int id)
        {
            var result = _vatuService.GetSingleVatus(id);
            if (result is null)
                return NotFound("nao encontrado");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Vatus>>> AddVatus(Vatus dados)
        {
            var result = _vatuService.AddVatus(dados);
            
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Vatus>>> PutVatus(int id, Vatus request)
        {
            var result = _vatuService.PutVatus(id, request);
            if (result is null)
                return NotFound("nao encontrado");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Vatus>>> DeleteVatus(int id)
        {
            var result = _vatuService.DeleteVatus(id) ;
            if (result is null)
                return NotFound("nao encontrado");
            return Ok(result);
        }
    }
}
