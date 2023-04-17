using FreeCourse.Services.Order.Application.Commands;
using FreeCourse.Services.Order.Application.Queries;
using FreeCourse.Shared.ControllerBases;
using FreeCourse.Shared.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : CustomBaseController
    {
        private readonly IMediator _mediator;
        private readonly IShareIdentityService _shareIdentityService;

        public OrdersController(IMediator mediator, IShareIdentityService shareIdentityService)
        {
            _mediator = mediator;
            _shareIdentityService = shareIdentityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var response =  await _mediator.Send(new GetOrdersByUserIdQuery { UserId = _shareIdentityService.GetUserId});

            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrder(CreateOrderCommand createOrderCommand)
        {
            var response = await _mediator.Send(createOrderCommand);

            return CreateActionResultInstance(response);
        }
    }
}
