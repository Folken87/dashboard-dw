using dashboard_dw_back.Models;
using dashboard_dw_back.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dashboard_dw_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtrtittionYouth : ControllerBase
    {
        /// <summary>
        /// Получение всех данных по выбывающим людям
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public IEnumerable<AttritionYouthView> GetData()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.AttritionYouthView.ToList();
            }
        }
    }
}
