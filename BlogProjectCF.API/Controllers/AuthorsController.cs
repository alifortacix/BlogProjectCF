using BlogProjectCF.BusinessL.Managers.Abstract;
using BlogProjectCF.Dtos.AuthorDtos;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectCF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IValidator<CreateAuthorDto> _authorValidator;
        private readonly IAuthorManager _authorManager;
        public AuthorsController(IValidator<CreateAuthorDto> authorValidator, IAuthorManager authorManager)
        {
            _authorValidator = authorValidator;
            _authorManager = authorManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = _authorManager.MGetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var data = _authorManager.MGet(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CreateAuthorDto authorDto) 
        {
            ValidationResult model = _authorValidator.Validate(authorDto);
            if(!model.IsValid)
                return BadRequest(model.Errors);

            _authorManager.MCreate(authorDto);
            return Ok("Author Added Successfully!");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromForm] UpdateAuthorDto authorDto)
        {
            _authorManager.MUpdate(authorDto);
            return Ok("Author Updated Successfully!");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            _authorManager.MDelete(id);
            return Ok("Author Deleted Successfully!");
        }

    }
}
