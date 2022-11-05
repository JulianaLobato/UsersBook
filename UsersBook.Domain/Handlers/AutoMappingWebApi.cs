using AutoMapper;
using UsersBook.Domain.Entities;
using UsersBook.Domain.Models;

namespace UsersBook.Domain.Handlers
{
    public class AutoMappingWebApi : Profile
    {
        public AutoMappingWebApi()
        {
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
