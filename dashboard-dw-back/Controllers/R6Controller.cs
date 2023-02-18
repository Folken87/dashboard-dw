using dashboard_dw_back.Models;
using dashboard_dw_back.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dashboard_dw_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class R6Controller : ControllerBase
    {
        private readonly ILogger<R6Controller> _logger;

        public R6Controller(ILogger<R6Controller> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Получение всех данных по разделу 6 - Вовлеченность в молодежные форумы
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetR6All")]
        public IEnumerable<R6View> Get()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.R6View.ToList();
            }
        }
    }
}
