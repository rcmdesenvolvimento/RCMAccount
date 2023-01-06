using AccountAPI.Models.AddCustomer;
using AccountAPI.Models.Error;
using Domain.Contracts.UseCase.AddCustomer;
using Domain.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        private readonly IAddCustomerUseCase _addCustomerUseCase;
        private readonly IValidator<AddCustomerInput> _AddCustomerInputValidator;

        public AddCustomerController(IAddCustomerUseCase addCustomerUseCase, IValidator<AddCustomerInput> AddCustomerInputValidator)
        {
            _addCustomerUseCase = addCustomerUseCase;
            _AddCustomerInputValidator = AddCustomerInputValidator;
        }

        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            var validationResult = _AddCustomerInputValidator.Validate(input);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.ToCustomValidationFailure());
            }

            var customer = new Customer(input.Name, input.Email, input.Document);

            _addCustomerUseCase.AddCustomer(customer);

            return Created("", customer);
        }
    }
}