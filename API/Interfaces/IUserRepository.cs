using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(appUser user);

        Task<bool> SaveAllAsync();

        Task<IEnumerable<appUser>> GetUsersAsync();

        Task<appUser> GetUserByIdAsync(int id);

        Task<appUser> GetUserByUsernameAsync(string username);

        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string username);

    }
}