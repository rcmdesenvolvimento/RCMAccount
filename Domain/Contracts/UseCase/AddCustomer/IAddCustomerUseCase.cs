using Domain.Entities;

namespace Domain.Contracts.UseCase.AddCustomer
{
    public interface IAddCustomerUseCase
    {
        void AddCustomer(Customer customer);

    }
}
