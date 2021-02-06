using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using aspnet_core_cqrs_mediator.Domain.Entities;

namespace aspnet_core_cqrs_mediator.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        void Insert(Customer entity);
        List<Customer> Query(Expression<Func<Customer, bool>> expression);
    }
}
