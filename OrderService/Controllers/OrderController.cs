using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;

namespace OrderService.Controllers
{
    [Route("api/v1/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        DatabaseContext _db;
        public OrderController(DatabaseContext db)
        {
            _db = db ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public async Task<IEnumerable<Order>> GetOrders()
        {
            try
            {
                return await _db.Orders.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
