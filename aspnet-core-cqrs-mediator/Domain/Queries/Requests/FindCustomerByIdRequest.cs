using System;
using aspnet_core_cqrs_mediator.Domain.Queries.Responses;
using MediatR;

namespace aspnet_core_cqrs_mediator.Domain.Queries.Requests
{
    public class FindCustomerByIdRequest : IRequest<FindCustomerByIdResponse>
    {
        public Guid Id { get; set; }
    }
}
