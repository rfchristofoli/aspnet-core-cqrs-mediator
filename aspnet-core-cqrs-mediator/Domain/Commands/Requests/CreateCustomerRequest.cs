using aspnet_core_cqrs_mediator.Domain.Commands.Responses;
using MediatR;

namespace aspnet_core_cqrs_mediator.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
