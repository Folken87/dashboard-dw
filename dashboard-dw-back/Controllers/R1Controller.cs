using dashboard_dw_back.Models;
using dashboard_dw_back.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dashboard_dw_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class R1Controller : ControllerBase
    {
        private readonly ILogger<R1Controller> _logger;

        public R1Controller(ILogger<R1Controller> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Получение всех данных по 1 разделу - Распределение бюджетов по направлениям молодёжной политики млн руб.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetR1All")]
        public IEnumerable<R1View> Get()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.R1View.ToList();
            }
        }
    }
}
