
using DTO.DTOs.LoginDtos;
using Entity.Entities;

namespace Business.Abstract
{
    public interface IJwtService
    {
        Task<LoginResponseDto> CreateTokenAsync(AppUser user);

    }
}
