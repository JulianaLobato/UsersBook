using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using UsersBook.Application.Interfaces;
using UsersBook.Domain.Interfaces.Services;
using UsersBook.Domain.Models;

namespace UsersBook.Application.AppServices
{
    public class UserAppService : IUserAppService
    {
        private readonly IMapper _mapper;
        private readonly IUserService _service;

        public UserAppService(IMapper mapper, IUserService service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<IList<UserModel>> Get()
        {
            return await Task.Run(() =>
            {
                return _mapper.Map<IList<UserModel>>(_service.Get());
            });
        }

        public async Task<UserModel> Get(int id)
        {
            return await Task.Run(() =>
            {
                return _mapper.Map<UserModel>(_service.Get(id));
            });
        }

        public async Task<int> Create(UserModel user)
        {
            return await Task.Run(() =>
            {
                return _service.Create(user);
            });
        }

        public async Task Update(int id, UserModel user)
        {
            await Task.Run(() => _service.Update(id, user));
        }

        public async Task Delete(int id)
        {
            await Task.Run(() => _service.Delete(id));
        }
    }
}
