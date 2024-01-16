using BlogProjectCF.BusinessL.Managers.Abstract;
using BlogProjectCF.Dtos.CategoryDtos;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectCF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IValidator<CreateCategoryDto> _createCategoryValidator;
        private readonly IValidator<UpdateCategoryDto> _updateCategoryValidator;
        public CategoriesController(ICategoryManager categoryManager, IValidator<CreateCategoryDto> createCategoryValidator, IValidator<UpdateCategoryDto> updateCategoryValidator)
        {
            _categoryManager = categoryManager;
            _createCategoryValidator = createCategoryValidator;
            _updateCategoryValidator = updateCategoryValidator;
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
        public IActionResult Post([FromForm] CreateCategoryDto createCategoryDto)
        {
            ValidationResult model = _createCategoryValidator.Validate(createCategoryDto);
            if (!model.IsValid)
                return BadRequest(model.Errors);

            _categoryManager.MCreate(createCategoryDto);
            return Ok("Successfully Created");
        }

        [HttpPut]
        public IActionResult Put([FromForm] UpdateCategoryDto updateCategoryDto)
        {
            ValidationResult model = _updateCategoryValidator.Validate(updateCategoryDto);
            if (!model.IsValid)
                return BadRequest(model.Errors);

            _categoryManager.MUpdate(updateCategoryDto);
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
