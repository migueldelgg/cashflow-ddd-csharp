using Microsoft.AspNetCore.Mvc;
using CashFlow.Communication.Requests;
using Microsoft.AspNetCore.Mvc.Formatters;
using CashFlow.Application.UseCases.Expenses.Register;

namespace CashFlowAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{

    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        var useCase = new RegisterExpenseUseCase();
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }
}

