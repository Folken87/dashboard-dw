using dashboard_dw_back.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dashboard_dw_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class R4Controller : ControllerBase
    {
        private readonly ILogger<R4Controller> _logger;

        public R4Controller(ILogger<R4Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetR4Data")]
        public IEnumerable<R4> Get()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.R4s.ToList();
            }
        }
    }
}
