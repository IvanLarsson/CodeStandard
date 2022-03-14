using CodeStandard.Domain.DTO;
using CodeStandard.Domain.Services;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeStandard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMyPocoService service;

        public ValuesController(IMyPocoService service)
        {
            this.service = service;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<MyPocoDTO>> Get()
        {
            return await service.GetAll();
        }




    }
}
