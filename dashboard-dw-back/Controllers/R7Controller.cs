using dashboard_dw_back.Models;
using dashboard_dw_back.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dashboard_dw_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class R7Controller : ControllerBase
    {
        private readonly ILogger<R7Controller> _logger;

        public R7Controller(ILogger<R7Controller> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Получение всех данных по разделу 6 - Вовлеченность в молодежные форумы
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetR7All")]
        public IEnumerable<R7View> Get()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.R7View.ToList();
            }
        }
    }
}
