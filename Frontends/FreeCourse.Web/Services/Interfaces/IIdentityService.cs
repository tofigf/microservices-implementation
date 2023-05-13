using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models;
using IdentityModel.Client;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<TokenResponse> GetAccessTokenByRefreshToken();
        Task<Response<bool>> SignIn(SigninInput signinInput);

        Task RevokeRefreshToken();
    }
}
