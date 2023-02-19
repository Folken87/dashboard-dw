using dashboard_dw_back.Models;
using dashboard_dw_back.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dashboard_dw_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class R2Controller : ControllerBase
    {
        private readonly ILogger<R4Controller> _logger;

        public R2Controller(ILogger<R4Controller> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Получение всех данных по 2 разделу - Получатели финансирования на работы с молодёжью млн руб.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetR2All")]
        public IEnumerable<R2View> Get()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.R2View.ToList();
            }
        }
    }
}
