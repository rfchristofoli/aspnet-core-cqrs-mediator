using aspnet_core_cqrs_mediator.Domain.Queries.Requests;
using aspnet_core_cqrs_mediator.Domain.Queries.Responses;

namespace aspnet_core_cqrs_mediator.Domain.Interfaces
{
    public interface IFindCustomerByIdHandler
    {
        FindCustomerByIdResponse Handle(FindCustomerByIdRequest command);
    }
}