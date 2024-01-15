using BlogProjectCF.BusinessL.Managers.Abstract;
using BlogProjectCF.BusinessL.Managers.Concrete;
using BlogProjectCF.Dtos.ArticleDtos;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectCF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleManager _articleManager;
        private readonly IValidator<CreateArticleDto> _createValidator;
        private readonly IValidator<UpdateArticleDto> _updateValidator;

        public ArticlesController(IArticleManager articleManager, IValidator<CreateArticleDto> validator, IValidator<UpdateArticleDto> updateValidator)
        {
            _articleManager = articleManager;
            _createValidator = validator;
            _updateValidator = updateValidator;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var data = _articleManager.MGetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var data = _articleManager.MGet(id);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromForm] CreateArticleDto articleDto)
        {
            ValidationResult model = _createValidator.Validate(articleDto);
            if (!model.IsValid)
                return BadRequest(model.Errors);

            _articleManager.MCreate(articleDto);
            return Ok("Succesfully Created");
        }

        [HttpPut]
        public IActionResult Put([FromForm] UpdateArticleDto articleDto)
        {
            ValidationResult model = _updateValidator.Validate(articleDto);
            if (!model.IsValid)
                return BadRequest(model.Errors);

            _articleManager.MUpdate(articleDto);
            return Ok("Succesfully Updated");
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            _articleManager.MDelete(id);
            return Ok("Succesfully Deleted");
        }
    }
}
