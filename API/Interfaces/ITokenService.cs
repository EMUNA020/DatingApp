using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
         string CeateToken(AppUser user);
    }
}