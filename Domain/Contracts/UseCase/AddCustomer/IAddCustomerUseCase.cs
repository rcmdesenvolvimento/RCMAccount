using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.UseCase.AddCustomer
{
    public interface IAddCustomerUseCase
    {
        void AddCustomer(Customer customer);

    }
}
