using dashboard_dw_back.Models;
using dashboard_dw_back.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dashboard_dw_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class R4_2Controller
    {
        private readonly ILogger<R4_2Controller> _logger;

        public R4_2Controller(ILogger<R4_2Controller> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Получение всех данных по разделу 4-2 - Вовлеченность учащихся в общественные объединения шт
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetR4-2All")]
        public IEnumerable<R4_2View> Get()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.R4_2View.ToList();
            }
        }
    }
}
