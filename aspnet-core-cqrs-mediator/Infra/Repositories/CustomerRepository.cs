using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using aspnet_core_cqrs_mediator.Domain.Entities;
using aspnet_core_cqrs_mediator.Domain.Interfaces;

namespace aspnet_core_cqrs_mediator.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Lazy<List<Customer>> _customers;

        public CustomerRepository()
        {
            _customers = new Lazy<List<Customer>>();
        }

        public void Insert(Customer entity) => _customers.Value.Add(entity);

        public List<Customer> Query(Expression<Func<Customer, bool>> expression) => _customers.Value.Where(expression.Compile()).ToList();
    }
}
