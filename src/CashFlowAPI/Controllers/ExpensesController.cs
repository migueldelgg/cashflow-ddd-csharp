﻿using Microsoft.AspNetCore.Mvc;
using CashFlow.Communication.Requests;

namespace CashFlowAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{

    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {

        return Created();
    }
}

