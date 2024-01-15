using AutoMapper;
using BlogProjectCF.BusinessL.Helpers;
using BlogProjectCF.BusinessL.Managers.Abstract;
using BlogProjectCF.DataAccessL.Repositories.Abstract;
using BlogProjectCF.Dtos.AuthorDtos;
using BlogProjectCF.EntityL.Concrete;

namespace BlogProjectCF.BusinessL.Managers.Concrete
{
    public class AuthorManager : IAuthorManager
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public AuthorManager(IAuthorRepository authorRepository,  IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public void MCreate(CreateAuthorDto authorDto)
        {
            Author newAuthor = _mapper.Map<Author>(authorDto);
            newAuthor.IsActive = true;
            newAuthor.CreatedDate = DateTime.Now;
            newAuthor.UpdatedDate = DateTime.Now;
            if (authorDto.Image != null)
            {
                string saveImageUrl = FileHelper.SaveFile(authorDto.Image, "/Uploads/Authors/");
                if(saveImageUrl != "FileSaveError")
                {
                    newAuthor.ImageUrl = "/Uploads/Authors/" + saveImageUrl;
                }
            }
            _authorRepository.Create(newAuthor);
        }


        public void MDelete(string id)
        {
            _authorRepository.Delete(id);
        }

        public Author MGet(string id)
        {
            return _authorRepository.Get(id);
        }

        public List<Author> MGetAll()
        {
            return _authorRepository.GetAll();
        }

        public List<Author> MGetAllByCondition(Func<Author, bool> predicate)
        {
            return _authorRepository.GetAllByCondition(predicate);
        }

        public Author MGetAuthorByUsernameAndPassword(string username, string password)
        {
            return _authorRepository.GetAuthorByUsernameAndPassword(username, password);
        }

        public void MUpdate(UpdateAuthorDto authorDto)
        {
            Author updatedAuthor = _mapper.Map<Author>(authorDto);
            updatedAuthor.UpdatedDate = DateTime.Now;
            if(authorDto.Image != null) 
            {
                var savedImagePath = FileHelper.SaveFile(authorDto.Image, "/Uploads/Authors/");
                updatedAuthor.ImageUrl = "/Uploads/Authors/" + savedImagePath;
            }
            _authorRepository.Update(updatedAuthor);
        }
    }
}
