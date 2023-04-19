using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<Response<bool>> SignIn(SigninInput signinInput);

        Task RevokeRefreshToken();
    }
}
