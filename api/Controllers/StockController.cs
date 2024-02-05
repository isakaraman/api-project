using api.Data;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class StockController : ControllerBase 
    {
        private readonly ApplicationDbContext _context;
        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var stocks = _context.Stock.ToList()
                .Select(s => s.ToStockDto());

            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) 
        {
            var stock= _context.Stock.Find(id);

            if (stock == null) 
            {
                return NotFound();
            }

            return Ok(stock.ToStockDto());
        }


    }  
}
