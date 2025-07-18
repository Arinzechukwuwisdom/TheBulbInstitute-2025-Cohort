using LibraryManagementSystem.DTOs.User;
using LibraryManagementSystem.Utilities;
namespace LibraryManagementSystem.Interfaces
{
    public interface IUserService
    {
        Task<ResponseModel<GetUserDTO>> CreateUser(CreateUserDTO userDetails);
        Task<ResponseModel<GetUserDTO>> GetUserByID(Guid id);
        Task<ResponseModel<List<GetUserDTO>>> GetAllUsers();
        Task<ResponseModel<GetUserDTO>> UpdateUser(CreateUserDTO userDetails, Guid id);
        Task<bool> Delete(Guid id);
    }
}
