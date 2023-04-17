using FreeCourse.Shared.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Services.Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IShareIdentityService _shareIdentityService;

        public OrdersController(IMediator mediator, IShareIdentityService shareIdentityService)
        {
            _mediator = mediator;
            _shareIdentityService = shareIdentityService;
        }
    }
}
