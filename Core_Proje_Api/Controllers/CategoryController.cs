using Core_Proje_Api.DAL.ApiContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var c = new Context();
            return Ok(c.Categories.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           using var c=new Context();
            var value = c.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
    }
}
