using aspnet_core_cqrs_mediator.Domain.Commands.Requests;
using aspnet_core_cqrs_mediator.Domain.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_cqrs_mediator.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateCustomer([FromBody] CreateCustomerRequest command)
        {
            var response = _mediator.Send(command);
            return Ok(response.Result);
        }

        [HttpGet]
        [Route("")]
        public IActionResult FindCustomerById([FromQuery] FindCustomerByIdRequest command)
        {
            var result = _mediator.Send(command);
            return Ok(result.Result);
        }
        
    }
}
