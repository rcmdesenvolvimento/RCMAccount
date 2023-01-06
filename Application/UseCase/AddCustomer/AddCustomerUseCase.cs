﻿using Domain.Contracts.Repositories.AddCustomer;
using Domain.Contracts.UseCase.AddCustomer;
using Domain.Entities;

namespace Application.UseCase.AddCustomer
{
    public class AddCustomerUseCase : IAddCustomerUseCase
    {
        private readonly IAddCustomerRepository _addCustomerRepository;

        public AddCustomerUseCase(IAddCustomerRepository addCustomerRepository)
        {
            _addCustomerRepository = addCustomerRepository;
        }   

        public void AddCustomer(Customer customer)
        {
            _addCustomerRepository.AddCustomer(customer);   
        }
    }
}
