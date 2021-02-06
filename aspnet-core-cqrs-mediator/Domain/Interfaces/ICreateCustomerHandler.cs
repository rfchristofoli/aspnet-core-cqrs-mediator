using aspnet_core_cqrs_mediator.Domain.Commands.Requests;
using aspnet_core_cqrs_mediator.Domain.Commands.Responses;

namespace aspnet_core_cqrs_mediator.Domain.Interfaces
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
}
