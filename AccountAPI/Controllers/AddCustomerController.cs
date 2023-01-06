﻿using AccountAPI.Models.AddCustomer;
using Domain.Contracts.UseCase.AddCustomer;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        private readonly IAddCustomerUseCase _addCustomerUseCase;

        public AddCustomerController(IAddCustomerUseCase addCustomerUseCase)
        {
            _addCustomerUseCase = addCustomerUseCase;
        }

        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            var customer = new Customer(input.Name, input.Email, input.Document);

            _addCustomerUseCase.AddCustomer(customer);

            return Created("", customer);

        }
    }
}