using System;
using System.Threading;
using System.Threading.Tasks;
using aspnet_core_cqrs_mediator.Domain.Commands.Requests;
using aspnet_core_cqrs_mediator.Domain.Commands.Responses;
using aspnet_core_cqrs_mediator.Domain.Entities;
using aspnet_core_cqrs_mediator.Domain.Interfaces;
using MediatR;

namespace aspnet_core_cqrs_mediator.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        ICustomerRepository _repository;

        public CreateCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.Name, request.Email);

            _repository.Insert(customer);

            return Task.FromResult(new CreateCustomerResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Date = DateTime.Now
            });
        }
    }
}
