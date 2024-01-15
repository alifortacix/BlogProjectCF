using BlogProjectCF.BusinessL.Managers.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectCF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;

        public CategoriesController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _categoryManager.MGetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var data = _categoryManager.MGet(id);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Successfully Created");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Successfully Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _categoryManager.MDelete(id);
            return Ok("Successfully Deleted");
        }
    }
}
