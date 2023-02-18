using dashboard_dw_back.Models;
using dashboard_dw_back.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dashboard_dw_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasicController : ControllerBase
    {
        /// <summary>
        /// Получение всех регионов РФ
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetSubjects")]
        public IEnumerable<Subject> GetSubjects()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.Subjects.Include(s => s.FedDistrict).ToList();
            }
        }

        /// <summary>
        /// Получение всех фед. округов
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetDistricts")]
        public IEnumerable<FederalDistrict> GetDistricts()
        {
            using (PostgresContext db = new PostgresContext())
            {
                return db.FederalDistricts.Include(fd => fd.Subjects).ToList();
            }
        }
    }
}
