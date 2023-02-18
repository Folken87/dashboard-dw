using dashboard_dw_back.Models;
using dashboard_dw_back.ViewModels;
using Microsoft.AspNetCore.Mvc;

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

        /// <summary>
        /// Получение всех данных по 4 разделу, например по "Политические молодeжные общественные объединения"
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetR4Data")]
        public IEnumerable<R4ViewModel> Get()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.R4ViewModel.ToList();
            }
        }

        /// <summary>
        /// Вывод всех данных, но вместо названий категорий/округов/регионов - их ключи
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetR4DataWithKeys")]
        public IEnumerable<R4> GetR4DataWithKeys()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.R4s.ToList();
            }
        }

        /// <summary>
        /// Получение всех видов категорий в разделе 4
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetR4Categories")]
        public IEnumerable<R4Category> GetCat()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.R4Categories.ToList();
            }
        }
    }
}
