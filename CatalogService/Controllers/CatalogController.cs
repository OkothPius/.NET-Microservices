using CatalogService.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Controllers
{
    [Route("api/v1/catalog")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        DatabaseContext _db;
        public CatalogController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            try
            {
                return await _db.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
