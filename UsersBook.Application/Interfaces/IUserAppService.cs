using System.Collections.Generic;
using System.Threading.Tasks;
using UsersBook.Domain.Models;

namespace UsersBook.Application.Interfaces
{
    public interface IUserAppService
    {
        Task<IList<UserModel>> Get();
        Task<UserModel> Get(int id);
        Task<int> Create(UserModel user);
        Task Update(int id, UserModel user);
        Task Delete(int id);
    }
}
