using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        // validacoes

        // persistir

        // retorno
        var expense = new ResponseRegisterExpenseJson
        {
            Title = "Conta de Luz"
        };
        return expense; 
    }
}

