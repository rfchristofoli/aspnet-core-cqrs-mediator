using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using aspnet_core_cqrs_mediator.Domain.Interfaces;
using aspnet_core_cqrs_mediator.Domain.Queries.Requests;
using aspnet_core_cqrs_mediator.Domain.Queries.Responses;
using MediatR;

namespace aspnet_core_cqrs_mediator.Domain.Handlers
{
    public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            var customer = _repository.Query(x => x.Id == request.Id);

            var result = (customer?.Any() ?? false) ? new FindCustomerByIdResponse
            {
                Id = customer[0].Id,
                Name = customer[0].Name,
                Email = customer[0].Email
            } : null;

            return Task.FromResult(result);
        }
    }
}
